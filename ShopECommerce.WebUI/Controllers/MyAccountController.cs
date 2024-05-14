using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;

namespace ShopECommerce.WebUI.Controllers
{
    [Authorize(Policy = "CustomerPolicy")]
    public class MyAccountController : Controller
    {
        private readonly IUserService _userService;
        public MyAccountController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        //[HttpGet]
        //public async Task<IActionResult> Index()
        //{
        //    var values = await _userService.FindByNameAsync(User.Identity.Name);
        //    updateUserDto appUserEditDto = new UpdateUserDto();
        //    updateUserDto.Name = values.Name;
        //    updateUserDto.Surname = values.Surname;
        //    updateUserDto.PhoneNumber = values.PhoneNumber;
        //    updateUserDto.Email = values.Email;
        //    updateUserDto.City = values.City;
        //    updateUserDto.District = values.District;
        //    updateUserDto.ImageUrl = values.ImageUrl;
        //    return View(appUserEditDto);
        //}
        //[HttpPost]
        //public async Task<IActionResult> Index(UpdateUserDto updateUserDto)
        //{
        //    if (updateUserDto.Password == updateUserDto.ConfirmPassword)
        //    {
        //        var user = await _userService.FindByNameAsync(User.Identity.Name);
        //        user.PhoneNumber = updateUserDto.PhoneNumber;
        //        user.Surname = updateUserDto.Surname;
        //        user.City = updateUserDto.City;
        //        user.District = updateUserDto.District;
        //        user.Name = updateUserDto.Name;
        //        user.ImageUrl = "test";
        //        user.Email = updateUserDto.Email;
        //        user.PasswordHash = _userService.PasswordHasher.HashPassword(user, updateUserDto.Password);
        //        var result = await _userService.UpdateAsync(user);
        //        if (result.Succeeded)
        //        {
        //            return RedirectToAction("Index", "Login");
        //        }
        //    }
        //    return View();
        //}
    }
}
