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

        [HttpGet("GetBasketByShopTableId")]
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

        //[HttpPost]
        //public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        //{
        //    var productPrice = _basketService.TGetProductPrice(createBasketDto.ProductId);

        //    _basketService.TAdd(new Basket()
        //    {
        //        ProductId = createBasketDto.ProductId,
        //        Count = 1,
        //        ShopTableId = 4,
        //        Price = productPrice,
        //        TotalPrice = 0,
        //    });
        //    return Ok();
        //}

        [HttpPost("CreateBasket")]
        public IActionResult CreateBasket(CreateBasketDto createBasketDto)
        {
            var productPrice = _basketService.TGetProductPrice(createBasketDto.ProductId);

            _basketService.TAdd(new Basket()
            {
                ProductId = createBasketDto.ProductId,
                Count = 1,
                ShopTableId = 1, // Burada ShopTableId'yi istediğiniz değere ayarlayın
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


        //[HttpDelete("{id}")] //SoftDelete
        //public IActionResult DeleteBasket(int id)
        //{
        //    var value = _basketService.TGetById(id);
        //    _basketService.TDelete(value);
        //    return Ok("Kategori Silindi");
        //}

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
