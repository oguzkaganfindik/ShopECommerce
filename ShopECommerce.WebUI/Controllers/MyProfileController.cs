using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Controllers
{
    [Authorize(Policy = "CustomerPolicy")]
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Update()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Update2()
        {
            return View();
        }
    }
}
