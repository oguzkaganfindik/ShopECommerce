using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.OrderComponents
{
    public class _OrderComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
