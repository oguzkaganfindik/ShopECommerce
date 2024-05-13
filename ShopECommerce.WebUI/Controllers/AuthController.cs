using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using ShopECommerce.Business.Abstract;
using ShopECommerce.Entities.Concrete;
using ShopECommerce.WebUI.Dtos.UserDtos;
using ShopECommerce.WebUI.Models;
using ShopECommerce.WebUI.Services.Abstract;
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
            _userService = userService;
            _emailService = emailService;
            _dataProtector = dataProtectionProvider.CreateProtector("password");
            _roleService = roleService;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(UserRegisterDto userRegisterDto)
        {
            if (ModelState.IsValid)
            {
                byte[] randomNumber = new byte[32];
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomNumber);
                }
                int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

                var rol =  _roleService.TGet(r => r.Name == "Customer");
                if (rol == null)
                {
                    ModelState.AddModelError("", "Kayıt Başarısız!");
                    return View();
                }

                var newUser = new User()
                {
                    Username = userRegisterDto.UserName,
                    FirstName = userRegisterDto.FirstName,
                    LastName = userRegisterDto.LastName,
                    Email = userRegisterDto.Email,
                    Password = _dataProtector.Protect(userRegisterDto.Password),
                    Description = "Kullanıcı Kayıt Oldu",
                    RoleId = rol.Id,
                    ConfirmCode = code
                };

                _userService.TAdd(newUser);

                await _emailService.SendConfirmationEmail(newUser.Email, code);

                TempData["Mail"] = userRegisterDto.Email;

                return RedirectToAction("ConfirmMail", "Auth");
            }
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
        public IActionResult ConfirmMail(ConfirmMailViewModel confirmMailViewModel)
        {
            var user = _userService.TGetByEmail(confirmMailViewModel.Mail);
            if (user != null && user.ConfirmCode == confirmMailViewModel.ConfirmCode)
            {
                user.Description = "Kullanıcı Mail Onayı Yaptı";
                user.EmailConfirmed = true;
                _userService.TUpdate(user);

                return RedirectToAction("Login", "Auth");
            }

            return RedirectToAction("AccessDenied");
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(UserLoginDto userLoginDto)
        {
            // Kullanıcıyı e-posta adresine göre bulalım
            var user = _userService.TGetByEmail(userLoginDto.Email);

            // Eğer kullanıcı varsa ve şifre doğruysa
            if (user != null && _dataProtector.Unprotect(user.Password) == userLoginDto.Password)
            {
                var rol = _roleService.TGet(r => r.Id == user.RoleId);
                var claims = new List<Claim>()
                    {
                        new Claim(ClaimTypes.Name, user.Username),
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.UserData, user.UserGuid.ToString())
                    };
                if (rol is not null)
                {
                    //claims.Add(new Claim("Role", rol.Adi));
                    claims.Add(new Claim(ClaimTypes.Role, rol.Name));
                }
                var userIdentity = new ClaimsIdentity(claims, "Login");
                ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
                await HttpContext.SignInAsync(principal);

                if (rol.Name == "Admin")
                {
                    return RedirectToAction("Index", "Dashboard", new { area = "Admin" });
                }
                else if (rol.Name == "User")
                {
                    return RedirectToAction("Index", "MyProfile");
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

        // E-posta onayı gerektiren bir sayfaya yönlendirme aksiyonu
        public IActionResult EmailConfirmationRequired()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
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
        public async Task<IActionResult> ForgotPassword(string email)
        {
            var user = _userService.TGetByEmail(email);
            if (user == null)
            {
                ModelState.AddModelError("Email", "Kullanıcı bulunamadı.");
                return View();
            }

            // Şifre sıfırlama kodu oluşturma
            byte[] randomNumber = new byte[32];
            using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
            {
                rng.GetBytes(randomNumber);
            }
            int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

            // Şifre sıfırlama bağlantısı oluşturma ve mail gönderme
            string resetLink = Url.Action("ResetPassword", "Auth", new { email = user.Email, code = code }, Request.Scheme);
            await _emailService.SendPasswordResetEmail(user.Email, resetLink);

            // Şifre sıfırlama kodunu ve kullanıcının e-posta adresini güncelleme
            user.ResetCode = code;
            _userService.TUpdate(user);

            TempData["Message"] = "Şifrenizi sıfırlamak için e-posta hesabınızı kontrol edin.";

            return RedirectToAction("Login");
        }

        [HttpGet]
        public IActionResult ResetPassword(string email, int code)
        {
            return View(new ResetPasswordViewModel { Email = email, Code = code });
        }

        [HttpPost]
        public IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            // Kullanıcıyı e-posta adresine göre bulalım
            var user = _userService.TGetByEmail(model.Email);

            // Kullanıcıyı kontrol et
            if (user != null && user.ResetCode == model.Code)
            {
                // Şifreyi güncelle
                user.Password = _dataProtector.Protect(model.Password);
                user.ResetCode = null; // Şifre sıfırlama kodunu temizle
                _userService.TUpdate(user);

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
        [Authorize] // Yetkilendirme
        public IActionResult ChangeMail()
        {
            return View();
        }

        [HttpPost]
        [Authorize] // Yetkilendirme
        public async Task<IActionResult> ChangeMail(ChangeMailDto model)
        {
            if (ModelState.IsValid)
            {
                var user = await _userService.TGetByEmailAndPassword(model.Email, _dataProtector.Protect(model.Password));
                if (user == null)
                {
                    ModelState.AddModelError("Password", "Mail adresi veya şifre hatalı.");
                    return View(model);
                }

                byte[] randomNumber = new byte[32];
                using (RandomNumberGenerator rng = RandomNumberGenerator.Create())
                {
                    rng.GetBytes(randomNumber);
                }
                int code = new Random(BitConverter.ToInt32(randomNumber, 0)).Next(100000, 1000000);

                string changeMailLink = Url.Action(nameof(ConfirmChangeMail), "Auth", new { email = model.Email, newEmail = model.NewEmail, code = code }, Request.Scheme);
                await _emailService.SendChangeMailConfirmationEmail(model.NewEmail, changeMailLink);

                user.ChangeMailCode = code;
                user.NewEmail = model.NewEmail;
                await _userService.TUpdateAsync(user);

                TempData["Message"] = "Yeni mail adresinize doğrulama maili gönderildi.";

                model.ChangeMailLink = changeMailLink;
                ViewBag.Email = model.Email;

                return View(model);
            }
            ModelState.Clear();
            return View();
        }




        [HttpGet]
        public async Task<IActionResult> ConfirmChangeMail(string email, string newEmail, int code)
        {
            var user = await _userService.TGetByEmailAndCode(email, code);
            if (user != null && user.NewEmail == newEmail && user.ChangeMailCode == code)
            {
                user.Email = newEmail;
                user.NewEmail = null;
                user.ChangeMailCode = null;
                await _userService.TUpdateAsync(user);

                await HttpContext.SignOutAsync();

                TempData["Message"] = "Mail adresiniz başarıyla değiştirildi.";

                var changeMailLink = Url.Action(nameof(Login), "Auth", null, Request.Scheme);
                var model = new ChangeMailDto
                {
                    ChangeMailLink = changeMailLink
                };

                return View(model);
            }

            TempData["Error"] = "Geçersiz doğrulama isteği.";
            return RedirectToAction(nameof(DefaultController.Index), "Home");
        }
    }
}