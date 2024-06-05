using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Services.Abstract;
using ShopECommerce.WebUI.ViewModels.SliderViewModels;
using System.Text;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class SliderController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IImageService _imageService;
        public SliderController(IHttpClientFactory httpClientFactory, IImageService imageService)
        {
            _httpClientFactory = httpClientFactory;
            _imageService = imageService;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Sliders");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultSliderViewModel>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public IActionResult CreateSlider()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateSlider(CreateSliderViewModel createSliderViewModel)
        {
            string newFileName1 = "";
            string filePath1 = "";
            string errorMessage1;
            newFileName1 = _imageService.Image(createSliderViewModel.File1, filePath1, out errorMessage1, "images", "sliders", 600, 400);

            if (!string.IsNullOrEmpty(newFileName1))
            {
                createSliderViewModel.ImagePath1 = "/images/sliders/" + newFileName1;
            }
            else
            {
                createSliderViewModel.ImagePath1 = "" + newFileName1;
            }

            string newFileName2 = "";
            string filePath2 = "";
            string errorMessage2;
            newFileName2 = _imageService.Image(createSliderViewModel.File2, filePath2, out errorMessage2, "images", "sliders", 600, 400);

            if (!string.IsNullOrEmpty(newFileName2))
            {
                createSliderViewModel.ImagePath2 = "/images/sliders/" + newFileName2;
            }
            else
            {
                createSliderViewModel.ImagePath2 = "" + newFileName2;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createSliderViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Sliders", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteSlider(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7046/api/Sliders/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateSlider(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Sliders/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateSliderViewModel>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateSlider(UpdateSliderViewModel updateSliderViewModel)
        {
            var existingSlider = await GetSliderById(updateSliderViewModel.Id);

            if (updateSliderViewModel.File1 == null || updateSliderViewModel.File1.Length == 0)
            {
                updateSliderViewModel.ImagePath1 = existingSlider.ImagePath1;
            }
            else
            {
                string newFileName1 = "";
                string filePath1 = "/images/sliders/";
                string errorMessage1;

                newFileName1 = _imageService.Image(updateSliderViewModel.File1, filePath1, out errorMessage1, "images", "sliders", 600, 400);

                if (!string.IsNullOrEmpty(newFileName1))
                {
                    updateSliderViewModel.ImagePath1 = "/images/sliders/" + newFileName1;
                }
                else
                {
                    updateSliderViewModel.ImagePath1 = existingSlider.ImagePath1;
                }
            }

            if (updateSliderViewModel.File2 == null || updateSliderViewModel.File2.Length == 0)
            {
                updateSliderViewModel.ImagePath2 = existingSlider.ImagePath2;
            }
            else
            {
                string newFileName2 = "";
                string filePath2 = "/images/sliders/";
                string errorMessage2;

                newFileName2 = _imageService.Image(updateSliderViewModel.File2, filePath2, out errorMessage2, "images", "sliders", 600, 400);

                if (!string.IsNullOrEmpty(newFileName2))
                {
                    updateSliderViewModel.ImagePath2 = "/images/sliders/" + newFileName2;
                }
                else
                {
                    updateSliderViewModel.ImagePath2 = existingSlider.ImagePath2;
                }
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateSliderViewModel);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync("https://localhost:7046/api/Sliders/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        private async Task<UpdateSliderViewModel> GetSliderById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Sliders/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var slider = JsonConvert.DeserializeObject<UpdateSliderViewModel>(jsonData);
                return slider;
            }
            return null;
        }

        public async Task<IActionResult> ToggleStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/Sliders/ToggleStatus/{id}");
            return RedirectToAction("Index");
        }
    }
}
