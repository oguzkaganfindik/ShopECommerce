using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.SocialMediaDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SocialMediaController : ControllerBase
    {
        private readonly ISocialMediaService _socialMediaService;
        private readonly IMapper _mapper;

        public SocialMediaController(ISocialMediaService socialMediaService, IMapper mapper)
        {
            _socialMediaService = socialMediaService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SocialMediaListAsync()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(await _socialMediaService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultSocialMediaDto>>(await _socialMediaService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSocialMediaAsync(CreateSocialMediaDto createSocialMediaDto)
        {
            await _socialMediaService.TAddAsync(new SocialMedia()
            {
                Title = createSocialMediaDto.Title,
                Cls = createSocialMediaDto.Cls,
                Icon = createSocialMediaDto.Icon,
                Url = createSocialMediaDto.Url
            });

            return Ok("Sosyal Medya Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSocialMediaAsync(int id)
        {
            var value = await _socialMediaService.TGetByIdAsync(id);
            await _socialMediaService.TDeleteAsync(value);
            return Ok("Sosyal Medya Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSocialMediaAsync(int id)
        {
            var value = await _socialMediaService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSocialMediaAsync(UpdateSocialMediaDto updateSocialMediaDto)
        {
            await _socialMediaService.TUpdateAsync(new SocialMedia()
            {
                Id = updateSocialMediaDto.Id,
                Title = updateSocialMediaDto.Title,
                Cls=updateSocialMediaDto.Cls,
                Icon = updateSocialMediaDto.Icon,
                Url = updateSocialMediaDto.Url
            });

            return Ok("Sosyal Medya Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _socialMediaService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }    
    }
}
