using ShopECommerce.WebUI.Services.Abstract;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.WebUI.ViewModels.MailViewModels;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class MailController : Controller
    {
        private readonly IEmailService _emailService;

        public MailController(IEmailService emailService)
        {
            _emailService = emailService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateMailViewModel createMailViewModel)
        {
            await _emailService.SendEmailAsync(createMailViewModel.ReceiverMail, createMailViewModel.Subject, createMailViewModel.Body);

            return RedirectToAction("Index", "Statistic");
        }
    }
}
