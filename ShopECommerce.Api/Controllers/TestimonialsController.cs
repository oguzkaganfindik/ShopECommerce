using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.TestimonialDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestimonialsController : ControllerBase
    {
        private readonly ITestimonialService _testimonialService;
        private readonly IMapper _mapper;

        public TestimonialsController(ITestimonialService testimonialService, IMapper mapper)
        {
            _testimonialService = testimonialService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> TestimonialListAsync()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(await _testimonialService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultTestimonialDto>>(await _testimonialService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTestimonialAsync(CreateTestimonialDto createTestimonialDto)
        {
            await _testimonialService.TAddAsync(createTestimonialDto);
            return Ok("Müşteri Yorum Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTestimonialAsync(int id)
        {
            var value = await _testimonialService.TGetByIdAsync(id);
            await _testimonialService.TDeleteAsync(value);
            return Ok("Müşteri Yorum Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetTestimonialAsync(int id)
        {
            var value = await _testimonialService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateTestimonialAsync(UpdateTestimonialDto updateTestimonialDto)
        {
            await _testimonialService.TUpdateAsync(updateTestimonialDto);
            return Ok("Müşteri Yorum Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _testimonialService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }
    }
}
