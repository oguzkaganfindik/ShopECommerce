using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.FactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactController : ControllerBase
    {
        private readonly IFactService _factService;
        private readonly IMapper _mapper;

        public FactController(IFactService factService, IMapper mapper)
        {
            _factService = factService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult FactList()
        {
            var value = _mapper.Map<List<ResultFactDto>>(_factService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultFactDto>>(_factService.TGetListByStatusTrue());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateFact(CreateFactDto createFactDto)
        {
            _factService.TAdd(new Fact()
            {
                Title = createFactDto.Title,
                Description = createFactDto.Description,
                Icon = createFactDto.Icon
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteFact(int id)
        {
            var value = _factService.TGetById(id);
            _factService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetFact(int id)
        {
            var value = _factService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateFact(UpdateFactDto updateFactDto)
        {
            _factService.TUpdate(new Fact()
            {
                Id = updateFactDto.Id,
                Title = updateFactDto.Title,
                Description = updateFactDto.Description,
                Icon = updateFactDto.Icon
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _factService.TToggleStatus(id);
            return Ok("Değiştirildi");
        }

        
    }
}
