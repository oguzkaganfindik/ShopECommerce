using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Dtos.ProductDtos;
using ShopECommerce.WebUI.Dtos.SubCategoryDtos;
using ShopECommerce.WebUI.Services.Abstract;
using System.Text;

namespace ShopECommerce.WebUI.Areas.Admin.Controllers
{
    [Area("Admin"), Authorize(Policy = "AdminPolicy")]
    public class ProductController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IImageProcessingService _imageProcessingService;
        private readonly IWebHostEnvironment _environment;
        private readonly IImageService _ImageManager;

        public ProductController(IHttpClientFactory httpClientFactory, IImageProcessingService imageProcessingService, IWebHostEnvironment environment, IImageService imageManager)
        {
            _httpClientFactory = httpClientFactory;
            _imageProcessingService = imageProcessingService;
            _environment = environment;
            _ImageManager = imageManager;
        }

        public async Task<IActionResult> Index()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Product/ProductListWithSubCategory");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<ResultProductWithSubCategory>>(jsonData);
                return View(values);
            }

            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Product/GetProductShowcaseDetailId/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                if (!string.IsNullOrEmpty(jsonData))
                {
                    var value = JsonConvert.DeserializeObject<GetProductShowcaseDetailDto>(jsonData);
                    if (value != null)
                    {
                        return View(value);
                    }
                }
            }
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> CreateProduct()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage1 = await client.GetAsync("https://localhost:7046/api/SubCategory");
            var jsonData = await responseMessage1.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultSubCategoryDto>>(jsonData);
            List<SelectListItem> values2 = (from x in values
                                            select new SelectListItem
                                            {
                                                Text = x.SubCategoryName,
                                                Value = x.Id.ToString()
                                            }).ToList();
            ViewBag.v = values2;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductDto createProductDto)
        {
            createProductDto.Status = true;


            string newFileName = "";
            string filePath = "";
            string errorMessage;

            newFileName = _ImageManager.Image(createProductDto.File, filePath, out errorMessage, "images", "products");

            if (!string.IsNullOrEmpty(newFileName))
            {
                createProductDto.ImagePath = "/images/products/" + newFileName;
            }
            else
            {
                createProductDto.ImagePath = "" + newFileName;
            }

            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(createProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("https://localhost:7046/api/Product", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public async Task<IActionResult> DeleteProduct(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.DeleteAsync($"https://localhost:7046/api/Product/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> UpdateProduct(int id)
        {
            var client1 = _httpClientFactory.CreateClient();
            var responseMessage1 = await client1.GetAsync("https://localhost:7046/api/SubCategory");
            var jsonData1 = await responseMessage1.Content.ReadAsStringAsync();
            var values1 = JsonConvert.DeserializeObject<List<ResultSubCategoryDto>>(jsonData1);
            List<SelectListItem> values2 = (from x in values1
                                            select new SelectListItem
                                            {
                                                Text = x.SubCategoryName,
                                                Value = x.Id.ToString()
                                            }).ToList();
            ViewBag.v = values2;

            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Product/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                return View(values);
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> UpdateProduct(UpdateProductDto updateProductDto)
        {
            // Eski resim yolu için mevcut ürünü al
            var existingProduct = await GetProductById(updateProductDto.Id);

            // Eğer resim dosyası gönderilmediyse veya güncellenmediyse
            if (updateProductDto.File == null || updateProductDto.File.Length == 0)
            {
                // Mevcut resim yolunu kullan
                updateProductDto.ImagePath = existingProduct.ImagePath;
            }
            else
            {
                // Yeni bir resim yüklenmişse, bu yeni resmin yolu olacak
                string newFileName = "";
                string filePath = "/images/products/";
                string errorMessage;

                newFileName = _ImageManager.Image(updateProductDto.File, filePath, out errorMessage, "images", "products");

                if (!string.IsNullOrEmpty(newFileName))
                {
                    updateProductDto.ImagePath = "/images/products/" + newFileName;
                }
                else
                {
                    // Hata durumunda eski resim yolu kullanılacak
                    updateProductDto.ImagePath = existingProduct.ImagePath;
                }
            }

            // Diğer alanları güncelle
            var client = _httpClientFactory.CreateClient();
            var jsonData = JsonConvert.SerializeObject(updateProductDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PutAsync($"https://localhost:7046/api/Product/", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        // Ürünü Id'ye göre alacak yardımcı metot
        private async Task<UpdateProductDto> GetProductById(int id)
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync($"https://localhost:7046/api/Product/{id}");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var product = JsonConvert.DeserializeObject<UpdateProductDto>(jsonData);
                return product;
            }
            // Eğer ürün bulunamazsa null döndür
            return null;
        }

        public async Task<IActionResult> ToggleStatus(int id)
        {
            var client = _httpClientFactory.CreateClient();
            await client.GetAsync($"https://localhost:7046/api/Product/ToggleStatus/{id}");
            return RedirectToAction("Index");
        }
    }
}
