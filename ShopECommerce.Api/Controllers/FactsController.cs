using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.FactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FactsController : ControllerBase
    {
        private readonly IFactService _factService;
        private readonly IMapper _mapper;

        public FactsController(IFactService factService, IMapper mapper)
        {
            _factService = factService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> FactListAsync()
        {
            var value = _mapper.Map<List<ResultFactDto>>(await _factService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultFactDto>>(await _factService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateFactAsync(CreateFactDto createFactDto)
        {
            await _factService.TAddAsync(new Fact()
            {
                Title = createFactDto.Title,
                Description = createFactDto.Description,
                Icon = createFactDto.Icon
            });

            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteFactAsync(int id)
        {
            var value = await _factService.TGetByIdAsync(id);
            await _factService.TDeleteAsync(value);
            return Ok("Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetFactAsync(int id)
        {
            var value = await _factService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateFactAsync(UpdateFactDto updateFactDto)
        {
            await _factService.TUpdateAsync(new Fact()
            {
                Id = updateFactDto.Id,
                Title = updateFactDto.Title,
                Description = updateFactDto.Description,
                Icon = updateFactDto.Icon
            });

            return Ok("Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _factService.TToggleStatusAsync(id);
            return Ok("Değiştirildi");
        }

        
    }
}
