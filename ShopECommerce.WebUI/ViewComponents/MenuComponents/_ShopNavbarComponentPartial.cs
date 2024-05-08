using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.MenuComponents
{
    public class _ShopNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
