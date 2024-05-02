using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ClientUserCount()
        {
            return View();
        }
    }
}
