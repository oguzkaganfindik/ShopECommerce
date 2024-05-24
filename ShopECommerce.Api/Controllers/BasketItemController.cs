using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BasketItemDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketItemController : ControllerBase
    {
        private readonly IBasketItemService _basketItemService;
        public BasketItemController(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        [HttpGet("BasketItemCount")]
        public async Task<IActionResult> BasketItemCountAsync()
        {
            return Ok(await _basketItemService.TBasketItemCountAsync());
        }

        [HttpGet]
        public IActionResult BasketItemList()
        {
            var values = _basketItemService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateBasketItem(CreateBasketItemDto createBasketItemDto)
        {
            BasketItem BasketItem = new BasketItem()
            {
                BasketItemCustomerMail = createBasketItemDto.BasketItemCustomerMail,
                Status = false
            };

            _basketItemService.TAdd(BasketItem);
            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBasketItem(int id)
        {
            var value = _basketItemService.TGetById(id);
            _basketItemService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpPut]
        public IActionResult UpdateBasketItem(UpdateBasketItemDto updateBasketItemDto)
        {
            BasketItem BasketItem = new BasketItem()
            {
                BasketItemCustomerMail = updateBasketItemDto.BasketItemCustomerMail,
                Status = false,
                Id = updateBasketItemDto.Id
            };

            _basketItemService.TUpdate(BasketItem);
            return Ok("Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBasketItem(int id)
        {
            var value = _basketItemService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _basketItemService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_basketItemService.TGetListByStatusTrue());
        }
    }
}
