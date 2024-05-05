using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
