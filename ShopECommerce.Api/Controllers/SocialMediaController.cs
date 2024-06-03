using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.SocialMediaDto;

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
            await _socialMediaService.TAddAsync(createSocialMediaDto);
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
            await _socialMediaService.TUpdateAsync(updateSocialMediaDto);
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
