using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.DiscountDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountsController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountsController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> DiscountListAsync()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(await _discountService.TGetAllAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateDiscountAsync(CreateDiscountDto createDiscountDto)
        {
            await _discountService.TAddAsync(createDiscountDto);
            return Ok("İndirim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDiscountAsync(int id)
        {
            var value = await _discountService.TGetByIdAsync(id);
            await _discountService.TDeleteAsync(value);
            return Ok("İndirim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetDiscountAsync(int id)
        {
            var value = await _discountService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateDiscountAsync(UpdateDiscountDto updateDiscountDto)
        {
            await _discountService.TUpdateAsync(updateDiscountDto);
            return Ok("İndirim Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _discountService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _discountService.TGetListByStatusTrueAsync());
        }
    }
}
