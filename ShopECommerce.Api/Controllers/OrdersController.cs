using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.OrderDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrdersController(IOrderService Orderervice, IMapper mapper)
        {
            _orderService = Orderervice;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> OrderListAsync()
        {
            var value = _mapper.Map<List<ResultOrderDto>>(await _orderService.TGetAllAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateOrderAsync(CreateOrderDto createOrderDto)
        {
            await _orderService.TAddAsync(createOrderDto);
            return Ok("Order Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteOrderAsync(int id)
        {
            var value = await _orderService.TGetByIdAsync(id);
            await _orderService.TDeleteAsync(value);
            return Ok("Order Alanı Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderAsync(int id)
        {
            var value = await _orderService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateOrderAsync(UpdateOrderDto updateOrderDto)
        {
            await _orderService.TUpdateAsync(updateOrderDto);
            return Ok("Order Alanı Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _orderService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultOrderDto>>(await _orderService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpGet("TotalOrderCount")]
        public async Task<IActionResult> TotalOrderCountAsync()
        {
            return Ok(await _orderService.TTotalOrderCountAsync());
        }

        [HttpGet("ActiveOrderCount")]
        public async Task<IActionResult> ActiveOrderCountAsync()
        {
            return Ok(await _orderService.TActiveOrderCountAsync());
        }

        [HttpGet("LastOrderPrice")]
        public async Task<IActionResult> LastOrderPriceAsync()
        {
            return Ok(await _orderService.TLastOrderPriceAsync());
        }

        [HttpGet("TodayTotalPrice")]
        public async Task<IActionResult> TodayTotalPriceAsync()
        {
            return Ok(await _orderService.TTodayTotalPriceAsync());
        }
    }
}
