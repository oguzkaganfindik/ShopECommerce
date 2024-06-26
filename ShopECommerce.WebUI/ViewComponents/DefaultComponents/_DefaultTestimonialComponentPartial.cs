﻿using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ShopECommerce.WebUI.ViewModels.TestimonialViewModels;

namespace ShopECommerce.WebUI.ViewComponents.DefaultComponents
{
    public class _DefaultTestimonialComponentPartial : ViewComponent
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public _DefaultTestimonialComponentPartial(IHttpClientFactory httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var client = _httpClientFactory.CreateClient();
            var responseMessage = await client.GetAsync("https://localhost:7046/api/Testimonials/GetListByStatusTrue/");

            var jsonData = await responseMessage.Content.ReadAsStringAsync();
            var values = JsonConvert.DeserializeObject<List<ResultTestimonialViewModel>>(jsonData);
            return View(values);


        }
    }
}
