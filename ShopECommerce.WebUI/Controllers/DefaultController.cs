using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Dtos.MessageDtos;
using ShopECommerce.WebUI.Dtos.NotificationDtos;
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
        public async Task<IActionResult> SendMessage(CreateMessageDto createMessageDto)
        {
            createMessageDto.Description = "Mesaj Alındı";
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createMessageDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Message", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                await CreateNotification("Yeni Mesajınız Var");
                return RedirectToAction("Index");
            }
            return View();
        }

        private async Task<IActionResult> CreateNotification(string description)
        {
            CreateNotificationDto createNotificationDto = new CreateNotificationDto()
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

            var responseMessage = await client.PostAsync("https://localhost:7046/api/Notification", stringContent);

            return RedirectToAction("Index");
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
