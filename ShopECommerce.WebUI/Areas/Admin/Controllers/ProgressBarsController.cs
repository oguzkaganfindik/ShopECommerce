﻿using Microsoft.AspNetCore.Mvc;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProgressBarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
