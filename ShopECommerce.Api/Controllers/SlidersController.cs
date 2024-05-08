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
        public IActionResult SliderList()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultSliderDto>>(_sliderService.TGetListByStatusTrue());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateSlider(CreateSliderDto createSliderDto)
        {
            _sliderService.TAdd(new Slider()
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
        public IActionResult DeleteSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            _sliderService.TDelete(value);
            return Ok("Slider Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSlider(int id)
        {
            var value = _sliderService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSlider(UpdateSliderDto updateSliderDto)
        {
            _sliderService.TUpdate(new Slider()
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
        public IActionResult ToggleStatus(int id)
        {
            _sliderService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }    
    }
}
