using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Dtos.BookingDtos;
using System.Text;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class BookATableController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public BookATableController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Index(CreateBookingDto createBookingDto)
        {
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createBookingDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Booking", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Default");
            }
            return View();
        }

        public async Task<IActionResult> ToggleStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/BookATable/ToggleStatus/{id}");
            return RedirectToAction("Index");
        }
    }
}
