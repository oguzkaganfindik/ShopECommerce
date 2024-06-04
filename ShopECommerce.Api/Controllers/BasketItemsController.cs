using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BasketItemDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BasketItemsController : ControllerBase
    {
        private readonly IBasketItemService _basketItemService;
        public BasketItemsController(IBasketItemService basketItemService)
        {
            _basketItemService = basketItemService;
        }

        [HttpGet("BasketItemCount")]
        public async Task<IActionResult> BasketItemCountAsync()
        {
            return Ok(await _basketItemService.TBasketItemCountAsync());
        }

        [HttpGet]
        public async Task<IActionResult> BasketItemListAsync()
        {
            var values = await _basketItemService.TGetAllAsync();
            return Ok(values);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBasketItemAsync(CreateBasketItemDto createBasketItemDto)
        {
            await _basketItemService.TAddAsync(createBasketItemDto);
            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBasketItemAsync(int id)
        {
            var value = await _basketItemService.TGetByIdAsync(id);
            await _basketItemService.TDeleteAsync(value);
            return Ok("Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBasketItemAsync(UpdateBasketItemDto updateBasketItemDto)
        {
            await _basketItemService.TUpdateAsync(updateBasketItemDto);
            return Ok("Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBasketItemAsync(int id)
        {
            var value = await _basketItemService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _basketItemService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _basketItemService.TGetListByStatusTrueAsync());
        }
    }
}