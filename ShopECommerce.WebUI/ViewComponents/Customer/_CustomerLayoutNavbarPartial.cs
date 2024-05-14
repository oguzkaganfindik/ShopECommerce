using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.Customer
{
    public class _CustomerLayoutNavbarPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
