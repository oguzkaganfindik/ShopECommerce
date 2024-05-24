using Microsoft.AspNetCore.Mvc;
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

        [HttpGet("GetBasketByBasketItemId")]
        public async Task<IActionResult> GetBasketByBasketItemIdAsync(int id)
        {
            var values = await _basketService.TGetBasketByBasketItemNumberAsync(id);
            return Ok(values);
        }

        [HttpGet("BasketListByBasketItemWithProductName")]
        public async Task<IActionResult> BasketListByBasketItemWithProductNameAsync(int id)
        {
            var values = await _basketService.TGetBasketListByBasketItemWithProductNameAsync(id);
            return Ok(values);
        }

        [HttpPost("CreateBasket")]
        public async Task<IActionResult> CreateBasketAsync(CreateBasketDto createBasketDto)
        {
            var productPrice = await _basketService.TGetProductPriceAsync(createBasketDto.ProductId);

            _basketService.TAdd(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                Count = 1,
                BasketItemId = 1,
                Price = productPrice,
                TotalPrice = productPrice,
            });
            return Ok();
        }

        [HttpPost("UpdateBasketQuantity")]
        public async Task<IActionResult> UpdateBasketQuantityAsync(int productId, int newQuantity)
        {
            await _basketService.TUpdateQuantityAsync(productId, newQuantity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasket(int id)
        {
            _basketService.THardDelete(id);
            return Ok("Basketteki Ürün Kalıcı Olarak Silindi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _basketService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_basketService.TGetListByStatusTrue());
        }
    }
}
