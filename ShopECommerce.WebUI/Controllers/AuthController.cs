using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.Entities.Concrete;
using ShopECommerce.WebUI.Models;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.ViewModels.UserViewModels;
using System.Security.Claims;
using System.Security.Cryptography;

namespace ShopECommerce.WebUI.Controllers
{
    public class AuthController : Controller
    {
        private readonly IUserService _userService;
        private readonly IRoleService _roleService;
        private readonly IEmailService _emailService;
        private readonly IDataProtector _dataProtector;

        public AuthController(IUserService userService, IEmailService emailService, IDataProtectionProvider dataProtectionProvider, IRoleService roleService)
        {
            _dataProtector = dataProtectionProvider.CreateProtector("security");
            _userService = userService;
            _emailService = emailService;
            _roleService = roleService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> RegisterAsync(UserRegisterViewModel userRegisterViewModel)
        {
            if (ModelState.IsValid)
            {
                if (userRegisterViewModel.Password != userRegisterViewModel.ConfirmPassword)
                {
                    ModelState.AddModelError("ConfirmPassword", "Şifreler eşleşmiyor.");
                    return View();
                }

                byte[] randomNumber = new byte[32];
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomNumber);
                }
                int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

                var rol = await _roleService.TGetAsync(r => r.Name == "Customer");
                if (rol == null)
                {
                    ModelState.AddModelError("", "Kayıt Başarısız!");
                    return View();
                }

                var newUser = new User()
                {
                    Username = userRegisterViewModel.UserName,
                    FirstName = userRegisterViewModel.FirstName,
                    LastName = userRegisterViewModel.LastName,
                    Email = userRegisterViewModel.Email,
                    Password = _dataProtector.Protect(userRegisterViewModel.Password),
                    Description = "Kullanıcı Kayıt Oldu",
                    RoleId = rol.Id,
                    ConfirmCode = code
                };

                await _userService.TAddAsync(newUser);

                await _emailService.SendConfirmationEmailAsync(newUser.Email, code);

                TempData["Mail"] = userRegisterViewModel.Email;

                return RedirectToAction("ConfirmMail", "Auth");
            }

            ModelState.AddModelError("Register", "Kayıt Başarısız Oldu. Lütfen Gerekli Alanları Kontrol Edip Yeniden Deneyiniz.");
            return View();
        }

        [HttpGet]
        public IActionResult ConfirmMail()
        {
            var value = TempData["Mail"];
            ViewBag.v = value;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmMailAsync(ConfirmMailViewModel confirmMailViewModel)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.TGetByEmailAsync(confirmMailViewModel.Mail);
                if (user != null && user.ConfirmCode == confirmMailViewModel.ConfirmCode)
                {
                    user.Description = "Kullanıcı Mail Onayı Yaptı";
                    user.EmailConfirmed = true;
                    await _userService.TUpdateAsync(user);

                    return RedirectToAction("Login", "Auth");
                }

                ModelState.AddModelError("ConfirmCode", "Email Kodunu Yanlış Girdiniz. Email Kodu Olmadan Kayıt İşleminiz Tamamlanamaz. Lütfen Yeniden Deneyin ya da Site Yöneticisi İle İletişime Geçiniz.");
            }

            return View();
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LoginAsync(UserLoginViewModel userLoginViewModel)
        {
            var user = await _userService.TGetByEmailAsync(userLoginViewModel.Email);

            if (user == null)
            {
                ModelState.AddModelError("", "Kullanıcı Adı ya da Şifre Hatalı.");
                return View();
            }

            if (!user.EmailConfirmed)
            {
                ModelState.AddModelError("EmailConfirmed", "Mail Adresiniz Henüz Doğrulanmamış. Bu şekilde Giriş Yapamazsınız.");
                return View();
            }

            if (!user.Status)
            {
                ModelState.AddModelError("Status", "Kullanıcı Kaydınız Pasif Durumdadır. Lütfen Site Yöneticisi İle İletişime Geçiniz.");
                return View();
            }

            if (user != null && _dataProtector.Unprotect(user.Password) == userLoginViewModel.Password)
            {
                var rol = await _roleService.TGetAsync(r => r.Id == user.RoleId);
                var claims = new List<Claim>()
            {
                new Claim(ClaimTypes.Name, user.Username),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.UserData, user.UserGuid.ToString())
            };
                if (rol is not null)
                {
                    claims.Add(new Claim(ClaimTypes.Role, rol.Name));
                }

                claims.Add(new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()));
                claims.Add(new Claim(ClaimTypes.GivenName, user.FirstName));
                claims.Add(new Claim(ClaimTypes.Surname, user.LastName));

                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                if (rol.Name == "SuperAdmin")
                {
                    return RedirectToAction("Index", "Statistic", new { area = "Admin" });
                }
                else if (rol.Name == "Admin")
                {
                    return RedirectToAction("Index", "Statistic", new { area = "Admin" });
                }
                else if (rol.Name == "User")
                {
                    return RedirectToAction("Index", "Default");
                }
                else if (rol.Name == "Customer")
                {
                    return RedirectToAction("Index", "Default");
                }
                return RedirectToAction("Index", "Default");
            }
            else
            {
                ModelState.AddModelError("", "Kullanıcı adı veya şifre hatalı.");
            }
            return View();
        }

        public async Task<IActionResult> LogOutAsync()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Default");
        }


        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ForgotPasswordAsync(string email)
        {
            var user = await _userService.TGetByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Kullanıcı bulunamadı.");
                return View();
            }

            byte[] randomNumber = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }
            int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

            string resetLink = Url.Action("ResetPassword", "Auth", new { email = user.Email, code = code }, Request.Scheme);
            await _emailService.SendPasswordResetEmailAsync(user.Email, resetLink);

            user.ResetCode = code;
            await _userService.TUpdateAsync(user);

            TempData["Message"] = "Şifrenizi sıfırlamak için e-posta hesabınızı kontrol edin.";

            return RedirectToAction("Index", "Default");
        }

        [HttpGet]
        public IActionResult ResetPassword(string email, int code)
        {
            return View(new ResetPasswordViewModel { Email = email, Code = code });
        }

        [HttpPost]
        public async Task<IActionResult> ResetPasswordAsync(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userService.TGetByEmailAsync(model.Email);

            if (user != null && user.ResetCode == model.Code)
            {
                user.Password = _dataProtector.Protect(model.Password);
                user.ResetCode = null;
                await _userService.TUpdateAsync(user);

                TempData["Message"] = "Şifreniz başarıyla güncellendi.";
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("", "Geçersiz şifre sıfırlama talebi.");
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult ChangeMail()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ChangeMailAsync(string email)
        {
            var user = await _userService.TGetByEmailAsync(email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Kullanıcı bulunamadı.");
                return View();
            }

            byte[] randomNumber = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }
            int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

            string changeMailLink = Url.Action("ConfirmChangeMail", "Auth", new { email = email, code = code }, Request.Scheme);
            await _emailService.SendChangeMailConfirmationEmailAsync(user.Email, changeMailLink);

            user.ChangeMailCode = code;

            await _userService.TUpdateAsync(user);

            TempData["Message"] = "Mail sıfırlamak için e-posta hesabınızı kontrol edin.";

            return RedirectToAction("Index", "Default");
        }


        [HttpGet]
        public IActionResult ConfirmChangeMail(string email, int code)
        {
            return View(new ConfirmChangeMailViewModel { Email = email, Code = code });
        }

        [HttpPost]
        public async Task<IActionResult> ConfirmChangeMailAsync(ConfirmChangeMailViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            var user = await _userService.TGetByEmailAsync(model.Email);

            if (user != null && user.ChangeMailCode == model.Code)
            {
                user.Email = model.NewEmail;
                user.ChangeMailCode = null;
                user.NewEmail = null;
                await _userService.TUpdateAsync(user);

                TempData["Message"] = "E-posta adresiniz başarıyla güncellendi.";
                return RedirectToAction("Login");
            }
            else
            {
                ModelState.AddModelError("", "Geçersiz e-posta değiştirme talebi.");
                return View(model);
            }
        }
    }
}