using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Controllers
{
    public class CustomerLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
