﻿using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketController(IBasketService basketService)
        {
            _basketService = basketService;
        }

        [HttpGet]
        public IActionResult GetBasketByMenuTableId(int id)
        {
            var values = _basketService.TGetBasketByMenuTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByMenuTableWithProductName")]
        public IActionResult BasketListByMenuTableWithProductName(int id)
        {
            var values = _basketService.TGetBasketListByMenuTableWithProductName(id);
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            var productPrice = _basketService.TGetProductPrice(createBasketDto.ProductId);

            _basketService.TAdd(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                Count = 1,
                MenuTableId = 4,
                Price = productPrice,
                TotalPrice = 0,
            });
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            var value = _basketService.TGetById(id);
            _basketService.TDelete(value);
            return Ok("Sepetteki Seçilen Ürün Silindi");
        }
    }
}