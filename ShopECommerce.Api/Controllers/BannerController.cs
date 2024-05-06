using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BannerDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannerController : ControllerBase
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public BannerController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BannerList()
        {
            var value = _mapper.Map<List<ResultBannerDto>>(_bannerService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultBannerDto>>(_bannerService.TGetListByStatusTrue());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateBanner(CreateBannerDto createBannerDto)
        {
            _bannerService.TAdd(new Banner()
            {
                Title = createBannerDto.Title,
                Description = createBannerDto.Description,
                
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBanner(int id)
        {
            var value = _bannerService.TGetById(id);
            _bannerService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBanner(int id)
        {
            var value = _bannerService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBanner(UpdateBannerDto updateBannerDto)
        {
            _bannerService.TUpdate(new Banner()
            {
                Id = updateBannerDto.Id,
                Title = updateBannerDto.Title,
                Description = updateBannerDto.Description,
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _bannerService.TToggleStatus(id);
            return Ok("Değiştirildi");
        }


    }
}
