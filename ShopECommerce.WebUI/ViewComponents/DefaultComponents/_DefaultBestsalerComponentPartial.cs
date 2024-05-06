using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.Dtos.ProductDtos;

namespace ShopECommerce.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultBestsalerComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;

        public _DefaultBestsalerComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/GetProducts");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultProductDto>>(jsonData);
            return View(values);


        }
    }
}
