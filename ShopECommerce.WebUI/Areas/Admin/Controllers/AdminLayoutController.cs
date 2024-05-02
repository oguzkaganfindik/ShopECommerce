using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminLayoutController : Controller
    {
        public IActionResult AdminLayout()
        {
            return View();
        }
    }
}
