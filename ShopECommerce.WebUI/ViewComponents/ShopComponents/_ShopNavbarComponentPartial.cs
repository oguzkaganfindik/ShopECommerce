using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.ShopComponents
{
    public class _ShopNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
