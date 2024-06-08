using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.ViewModels.DiscountViewModels;
using System.Text;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class DiscountController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IImageService _imageService;

        public DiscountController(IHttpClientFactory httpClientFactory, IImageService imageService)
        {
            _httpClientFactory = httpClientFactory;
            _imageService = imageService;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Discounts");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultDiscountViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Discounts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonData))
                {
                    var value = JsonConvert.DeserializeObject<GetDiscountViewModel>(jsonData);
                    if (value != null)
                    {
                        return View(value);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult CreateDiscount()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscount(CreateDiscountViewModel createDiscountViewModel)
        {
            string newFileName = "";
            string filePath = "";
            string errorMessage;

            newFileName = _imageService.Image(createDiscountViewModel.File, filePath, out errorMessage, "images", "discounts", 500, 375);

            if (!string.IsNullOrEmpty(newFileName))
            {
                createDiscountViewModel.ImagePath = "/images/discounts/" + newFileName;
            }
            else
            {
                createDiscountViewModel.ImagePath = "" + newFileName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createDiscountViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Discounts", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteDiscount(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7046/api/Discounts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateDiscount(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Discounts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateDiscountViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateDiscount(UpdateDiscountViewModel updateDiscountViewModel)
        {
            var existingProduct = await GetDiscountById(updateDiscountViewModel.Id);

            if (updateDiscountViewModel.File == null || updateDiscountViewModel.File.Length == 0)
            {
                updateDiscountViewModel.ImagePath = existingProduct.ImagePath;
            }
            else
            {
                string newFileName = "";
                string filePath = "/images/discounts/";
                string errorMessage;

                newFileName = _imageService.Image(updateDiscountViewModel.File, filePath, out errorMessage, "images", "discounts", 500, 375);

                if (!string.IsNullOrEmpty(newFileName))
                {
                    updateDiscountViewModel.ImagePath = "/images/discounts/" + newFileName;
                }
                else
                {
                    updateDiscountViewModel.ImagePath = existingProduct.ImagePath;
                }
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateDiscountViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7046/api/Discounts/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> ChangeStatusToTrue(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/Discounts/ChangeStatusToTrue/{id}");
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ChangeStatusToFalse(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/Discounts/ChangeStatusToFalse/{id}");
            return RedirectToAction("Index");
        }

        private async Task<UpdateDiscountViewModel> GetDiscountById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Discounts/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var discount = JsonConvert.DeserializeObject<UpdateDiscountViewModel>(jsonData);
                return discount;
            }
            return null;
        }

        public async Task<IActionResult> ToggleStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/Discounts/ToggleStatus/{id}");
            return RedirectToAction("Index");
        }
    }
}
