using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public async Task<IActionResult> LogOut()
        {
            return RedirectToAction("Index", "Login");
        }
    }
}
