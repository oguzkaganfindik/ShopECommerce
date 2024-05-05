using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Controllers
{
    public class UILayoutController : Controller
    {
        public IActionResult UILayout()
        {
            return View();
        }
    }
}
