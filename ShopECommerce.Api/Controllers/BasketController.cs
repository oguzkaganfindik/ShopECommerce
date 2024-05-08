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

        [HttpGet]
        public IActionResult GetBasketByShopTableId(int id)
        {
            var values = _basketService.TGetBasketByShopTableNumber(id);
            return Ok(values);
        }

        [HttpGet("BasketListByShopTableWithProductName")]
        public IActionResult BasketListByShopTableWithProductName(int id)
        {
            var values = _basketService.TGetBasketListByShopTableWithProductName(id);
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
                ShopTableId = 4,
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
