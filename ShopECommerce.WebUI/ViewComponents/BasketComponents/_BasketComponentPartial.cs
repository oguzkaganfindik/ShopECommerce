using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.BasketComponents
{
    public class _BasketComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
