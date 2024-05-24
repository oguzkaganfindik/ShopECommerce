using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.OrderDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly IMapper _mapper;

        public OrderController(IOrderService Orderervice, IMapper mapper)
        {
            _orderService = Orderervice;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult OrderList()
        {
            var value = _mapper.Map<List<ResultOrderDto>>(_orderService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateOrder(CreateOrderDto createOrderDto)
        {
            _orderService.TAdd(new Order()
            {
                BasketItemId = createOrderDto.BasketItemId,
                Description = createOrderDto.Description,
                OrderDate = createOrderDto.OrderDate,
                TotalPrice = createOrderDto.TotalPrice
            });

            return Ok("Order Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrder(int id)
        {
            var value = _orderService.TGetById(id);
            _orderService.TDelete(value);
            return Ok("Order Alanı Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetOrder(int id)
        {
            var value = _orderService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateOrder(UpdateOrderDto updateOrderDto)
        {
            _orderService.TUpdate(new Order()
            {
                Id = updateOrderDto.Id,
                BasketItemId = updateOrderDto.BasketItemId,
                Description = updateOrderDto.Description,
                OrderDate = updateOrderDto.OrderDate,
                TotalPrice = updateOrderDto.TotalPrice
            });

            return Ok("Order Alanı Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _orderService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultOrderDto>>(_orderService.TGetListByStatusTrue());
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
