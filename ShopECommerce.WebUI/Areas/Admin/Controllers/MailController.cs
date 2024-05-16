using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.Dtos.MailDtos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

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
        public async Task<IActionResult> Index(CreateMailDto createMailDto)
        {
            await _emailService.SendEmail(createMailDto.ReceiverMail, createMailDto.Subject, createMailDto.Body);

            return RedirectToAction("Index", "Statistic");
        }
    }
}
