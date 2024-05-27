using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BannerDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
        private readonly IBannerService _bannerService;
        private readonly IMapper _mapper;

        public BannersController(IBannerService bannerService, IMapper mapper)
        {
            _bannerService = bannerService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> BannerListAsync()
        {
            var value = _mapper.Map<List<ResultBannerDto>>(await _bannerService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultBannerDto>>(await _bannerService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateBannerAsync(CreateBannerDto createBannerDto)
        {
            await _bannerService.TAddAsync(new Banner()
            {
                Title = createBannerDto.Title,
                SubTitle = createBannerDto.SubTitle,
                Description = createBannerDto.Description,
                Url = createBannerDto.Url,
                UrlLabel = createBannerDto.UrlLabel,
                ImagePath = createBannerDto.ImagePath,
                Price1 = createBannerDto.Price1,
                Price2 = createBannerDto.Price2
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBannerAsync(int id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            await _bannerService.TDeleteAsync(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetBannerAsync(int id)
        {
            var value = await _bannerService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateBannerAsync(UpdateBannerDto updateBannerDto)
        {
            await _bannerService.TUpdateAsync(new Banner()
            {
                Id = updateBannerDto.Id,
                Title = updateBannerDto.Title,
                SubTitle = updateBannerDto.SubTitle,
                Description = updateBannerDto.Description,
                Url = updateBannerDto.Url,
                UrlLabel = updateBannerDto.UrlLabel,
                ImagePath = updateBannerDto.ImagePath,
                Price1 = updateBannerDto.Price1,
                Price2 = updateBannerDto.Price2
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _bannerService.TToggleStatusAsync(id);
            return Ok("Değiştirildi");
        }
    }
}
