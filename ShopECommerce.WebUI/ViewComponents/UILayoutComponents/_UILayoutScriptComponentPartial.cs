using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.UILayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
