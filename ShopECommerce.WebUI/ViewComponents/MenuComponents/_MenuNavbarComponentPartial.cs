﻿using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.ViewComponents.MenuComponents
{
    public class _MenuNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
