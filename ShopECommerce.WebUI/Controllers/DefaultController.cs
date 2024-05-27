using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.ViewModels.MessageViewModels;
using ShopECommerce.WebUI.ViewModels.NotificationViewModels;
using System.Text;

namespace ShopECommerce.WebUI.Controllers
{
    public class DefaultController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public DefaultController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Contact()
        {
            return PartialView();
        }

        public PartialViewResult Messenger()
        {
            return PartialView();
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(CreateMessageViewModel createMessageDto)
        {
            createMessageDto.Description = "Mesaj Alındı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMessageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Messages", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                await CreateNotification("Yeni Mesajınız Var");
                return RedirectToAction("Index");
            }
            return View();
        }

        private async Task<IActionResult> CreateNotification(string description)
        {
            CreateNotificationViewModel createNotificationDto = new CreateNotificationViewModel()
            {
                Description = description,
                Status = false,
                Icon = "la la-comment",
                Type = "notif-icon notif-success",
                CreatedDate = DateTime.Now
            };

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createNotificationDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7046/api/Notifications", stringContent);

            return RedirectToAction("Index");
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult PrivacyPolicy()
        {
            return View();
        }
        public IActionResult TermsOfUse()
        {
            return View();
        }

        [Route("AccessDenied")]
        public IActionResult AccessDenied()
        {
            return View();
        }
    }
}
