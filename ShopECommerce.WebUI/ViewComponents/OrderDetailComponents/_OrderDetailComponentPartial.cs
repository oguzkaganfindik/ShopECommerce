using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.OrderDetailComponents
{
    public class _OrderDetailComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
