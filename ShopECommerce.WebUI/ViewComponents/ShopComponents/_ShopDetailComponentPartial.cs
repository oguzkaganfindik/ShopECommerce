using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.ShopComponents
{
    public class _ShopDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
