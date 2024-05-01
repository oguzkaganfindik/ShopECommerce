using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Areas.Admin.ViewComponents.LayoutComponents
{
    public class _LayoutSidebarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
