using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BasketDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketsController : ControllerBase
    {
        private readonly IBasketService _basketService;

        public BasketsController(IBasketService basketService)
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
            await _basketService.TAddAsync(createBasketDto);
            return Ok();
        }

        [HttpPost("UpdateBasketQuantity")]
        public async Task<IActionResult> UpdateBasketQuantityAsync(int productId, int newQuantity)
        {
            await _basketService.TUpdateQuantityAsync(productId, newQuantity);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasketAsync(int id)
        {
            await _basketService.THardDeleteAsync(id);
            return Ok("Basketteki Ürün Kalıcı Olarak Silindi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _basketService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _basketService.TGetListByStatusTrueAsync());
        }
    }
}
