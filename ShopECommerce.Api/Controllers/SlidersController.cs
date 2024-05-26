using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.SliderDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SlidersController : ControllerBase
    {
        private readonly ISliderService _sliderService;
        private readonly IMapper _mapper;
        public SlidersController(ISliderService sliderService, IMapper mapper)
        {
            _sliderService = sliderService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SliderListAsync()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(await _sliderService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(await _sliderService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSliderAsync(CreateSliderDto createSliderDto)
        {
            await _sliderService.TAddAsync(new Slider()
            {
                Title = createSliderDto.Title,
                Description = createSliderDto.Description,
                Label1 = createSliderDto.Label1,
                ImagePath1 = createSliderDto.ImagePath1,
                Url1 = createSliderDto.Url1,
                Label2 = createSliderDto.Label2,
                ImagePath2 = createSliderDto.ImagePath2,
                Url2 = createSliderDto.Url2
            });

            return Ok("Slider Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSliderAsync(int id)
        {
            var value = await _sliderService.TGetByIdAsync(id);
            await _sliderService.TDeleteAsync(value);
            return Ok("Slider Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSliderAsync(int id)
        {
            var value = await _sliderService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSliderAsync(UpdateSliderDto updateSliderDto)
        {
            await _sliderService.TUpdateAsync(new Slider()
            {
                Title = updateSliderDto.Title,
                Description = updateSliderDto.Description,
                Label1 = updateSliderDto.Label1,
                ImagePath1 = updateSliderDto.ImagePath1,
                Url1 = updateSliderDto.Url1,
                Label2 = updateSliderDto.Label2,
                ImagePath2 = updateSliderDto.ImagePath2,
                Url2 = updateSliderDto.Url2
            });

            return Ok("Slider Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _sliderService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }    
    }
}
