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
        public IActionResult GetBasketByBasketItemId(int id)
        {
            var values = _basketService.TGetBasketByBasketItemNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByBasketItemWithProductName")]
        public IActionResult BasketListByBasketItemWithProductName(int id)
        {
            var values = _basketService.TGetBasketListByBasketItemWithProductName(id);
            return Ok(values);
        }

        [HttpPost("CreateBasket")]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            var productPrice = _basketService.TGetProductPrice(createBasketDto.ProductId);

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
        public IActionResult UpdateBasketQuantity(int productId, int newQuantity)
        {
            // Ürün miktarını güncelle
            _basketService.TUpdateQuantity(productId, newQuantity);
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
