using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class SignalRDefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Index2()
        {
            return View();
        }
    }
}
