using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.FeaturDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeaturController : ControllerBase
    {
        private readonly IFeaturService _featurService;
        private readonly IMapper _mapper;

        public FeaturController(IFeaturService featurService, IMapper mapper)
        {
            _featurService = featurService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FeaturList()
        {
            var value = _mapper.Map<List<ResultFeaturDto>>(_featurService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultFeaturDto>>(_featurService.TGetListByStatusTrue());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateFeatur(CreateFeaturDto createFeaturDto)
        {
            _featurService.TAdd(new Featur()
            {
                Title = createFeaturDto.Title,
                Description = createFeaturDto.Description,
                Icon = createFeaturDto.Icon
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFeatur(int id)
        {
            var value = _featurService.TGetById(id);
            _featurService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFeatur(int id)
        {
            var value = _featurService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFeatur(UpdateFeaturDto updateFeaturDto)
        {
            _featurService.TUpdate(new Featur()
            {
                Id = updateFeaturDto.Id,
                Title = updateFeaturDto.Title,
                Description = updateFeaturDto.Description,
                Icon = updateFeaturDto.Icon
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _featurService.TToggleStatus(id);
            return Ok("Değiştirildi");
        } 
    }
}
