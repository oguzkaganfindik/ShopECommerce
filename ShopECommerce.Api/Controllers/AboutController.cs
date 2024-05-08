using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.AboutDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult AboutList()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateAbout(CreateAboutDto createAboutDto)
        {
            _aboutService.TAdd(new About()
            {
                Title = createAboutDto.Title,
                Description = createAboutDto.Description,
                ImagePath = createAboutDto.ImagePath
            });

            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            _aboutService.TDelete(value);
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetAbout(int id)
        {
            var value = _aboutService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateAbout(UpdateAboutDto updateAboutDto)
        {
            _aboutService.TUpdate(new About()
            {
                Id = updateAboutDto.Id,
                Title = updateAboutDto.Title,
                Description = updateAboutDto.Description,
                ImagePath = updateAboutDto.ImagePath
            });

            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _aboutService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(_aboutService.TGetListByStatusTrue());
            return Ok(value);
        }
    }
}
