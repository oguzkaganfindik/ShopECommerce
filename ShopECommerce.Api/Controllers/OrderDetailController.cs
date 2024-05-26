using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.OrderDetailDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderDetailController : ControllerBase
    {
        private readonly IOrderDetailService _orderDetailService;
        private readonly IMapper _mapper;

        public OrderDetailController(IOrderDetailService OrderDetailService, IMapper mapper)
        {
            _orderDetailService = OrderDetailService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> OrderDetailListAsync()
        {
            var value = _mapper.Map<List<ResultOrderDetailDto>>(await _orderDetailService.TGetAllAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderDetailAsync(CreateOrderDetailDto createOrderDetailDto)
        {
            await _orderDetailService.TAddAsync(new OrderDetail()
            {
                OrderId = createOrderDetailDto.OrderId,
                ProductId = createOrderDetailDto.ProductId,
                Count = createOrderDetailDto.Count,
                TotalPrice = createOrderDetailDto.TotalPrice,
                UnitPrice = createOrderDetailDto.UnitPrice
            });

            return Ok("OrderDetail Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderDetailAsync(int id)
        {
            var value = await _orderDetailService.TGetByIdAsync(id);
            await _orderDetailService.TDeleteAsync(value);
            return Ok("OrderDetail Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderDetailAsync(int id)
        {
            var value = await _orderDetailService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderDetailAsync(UpdateOrderDetailDto updateOrderDetailDto)
        {
            await _orderDetailService.TUpdateAsync(new OrderDetail()
            {
                Id = updateOrderDetailDto.OrderId,
                OrderId = updateOrderDetailDto.OrderId,
                ProductId = updateOrderDetailDto.ProductId,
                Count = updateOrderDetailDto.Count,
                TotalPrice = updateOrderDetailDto.TotalPrice,
                UnitPrice = updateOrderDetailDto.UnitPrice
            });

            return Ok("OrderDetail Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _orderDetailService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultOrderDetailDto>>(await _orderDetailService.TGetListByStatusTrueAsync());
            return Ok(value);
        }
    }
}
