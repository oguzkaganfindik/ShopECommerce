using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.ViewModels.BasketViewModels;
using ShopECommerce.WebUI.ViewModels.ProductViewModels;
using System.Text;

namespace ShopECommerce.WebUI.Controllers
{
    public class ShopController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public ShopController(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Products");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductWithSubCategoryViewModel>>(jsonData);
            return View(values);
        }

        [HttpPost]
        public async Task<IActionResult> AddBasket(int id)
        {
            var client = _httpClientFactory.CreateClient();

            var jsonData = JsonConvert.SerializeObject(new CreateBasketViewModel { ProductId = id });
            var stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");

            var responseMessage = await client.PostAsync("https://localhost:7046/api/Baskets/CreateBasket", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index", "Shop");
            }
            else
            {
                var errorData = await responseMessage.Content.ReadAsStringAsync();
                ModelState.AddModelError("", errorData);
                return View("Error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Products/GetProductShowcaseDetailId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonData))
                {
                    var value = JsonConvert.DeserializeObject<GetProductShowcaseDetailViewModel>(jsonData);
                    if (value != null)
                    {
                        return View(value);
                    }
                }
            }
            return RedirectToAction("Index");
        }
    }
}