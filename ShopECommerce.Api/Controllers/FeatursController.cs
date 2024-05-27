using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.FeaturDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeatursController : ControllerBase
    {
        private readonly IFeaturService _featurService;
        private readonly IMapper _mapper;

        public FeatursController(IFeaturService featurService, IMapper mapper)
        {
            _featurService = featurService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> FeaturListAsync()
        {
            var value = _mapper.Map<List<ResultFeaturDto>>(await _featurService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultFeaturDto>>(await _featurService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFeaturAsync(CreateFeaturDto createFeaturDto)
        {
            await _featurService.TAddAsync(new Featur()
            {
                Title = createFeaturDto.Title,
                Description = createFeaturDto.Description,
                Icon = createFeaturDto.Icon
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFeaturAsync(int id)
        {
            var value = await _featurService.TGetByIdAsync(id);
            await _featurService.TDeleteAsync(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFeaturAsync(int id)
        {
            var value = await _featurService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFeaturAsync(UpdateFeaturDto updateFeaturDto)
        {
            await _featurService.TUpdateAsync(new Featur()
            {
                Id = updateFeaturDto.Id,
                Title = updateFeaturDto.Title,
                Description = updateFeaturDto.Description,
                Icon = updateFeaturDto.Icon
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _featurService.TToggleStatusAsync(id);
            return Ok("Değiştirildi");
        } 
    }
}
