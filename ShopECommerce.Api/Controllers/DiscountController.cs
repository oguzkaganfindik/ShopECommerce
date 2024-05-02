using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.DiscountDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DiscountController : ControllerBase
    {
        private readonly IDiscountService _discountService;
        private readonly IMapper _mapper;

        public DiscountController(IDiscountService discountService, IMapper mapper)
        {
            _discountService = discountService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult DiscountList()
        {
            var value = _mapper.Map<List<ResultDiscountDto>>(_discountService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateDiscount(CreateDiscountDto createDiscountDto)
        {
            _discountService.TAdd(new Discount()
            {
                Amount = createDiscountDto.Amount,
                Description = createDiscountDto.Description,
                ImageUrl = createDiscountDto.ImageUrl,
                Title = createDiscountDto.Title,
                Status = false,
            });

            return Ok("İndirim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            _discountService.TDelete(value);
            return Ok("İndirim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetDiscount(int id)
        {
            var value = _discountService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateDiscount(UpdateDiscountDto updateDiscountDto)
        {
            _discountService.TUpdate(new Discount()
            {
                Id = updateDiscountDto.Id,
                Amount = updateDiscountDto.Amount,
                ImageUrl = updateDiscountDto.ImageUrl,
                Title = updateDiscountDto.Title,
                Description = updateDiscountDto.Description,
                Status = false
            });

            return Ok("İndirim Bilgisi Güncellendi");
        }

        //[HttpGet("ChangeStatusToTrue/{id}")]
        //public IActionResult ChangeStatusToTrue(int id)
        //{
        //    _discountService.TChangeStatusToTrue(id);
        //    return Ok("Ürün İndirimi Aktif Hale Getirildi");
        //}

        //[HttpGet("ChangeStatusToFalse/{id}")]
        //public IActionResult ChangeStatusToFalse(int id)
        //{
        //    _discountService.TChangeStatusToFalse(id);
        //    return Ok("Ürün İndirimi Pasif Hale Getirildi");
        //}

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _discountService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_discountService.TGetListByStatusTrue());
        }

    }
}
