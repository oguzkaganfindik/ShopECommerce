using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.DiscountDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
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
            await _discountService.TAddAsync(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImagePath = createDiscountDto.ImagePath,
                Title = createDiscountDto.Title,
                Status = false,
            });

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
            await _discountService.TUpdateAsync(new Discount()
            {
                Id = updateDiscountDto.Id,
                Amount = updateDiscountDto.Amount,
                ImagePath = updateDiscountDto.ImagePath,
                Title = updateDiscountDto.Title,
                Description = updateDiscountDto.Description,
                Status = false
            });

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
