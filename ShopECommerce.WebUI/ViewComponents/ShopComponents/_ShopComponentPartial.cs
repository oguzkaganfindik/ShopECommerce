using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.ShopComponents
{
    public class _ShopComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
