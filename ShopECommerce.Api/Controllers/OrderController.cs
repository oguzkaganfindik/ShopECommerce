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
                ShopTableId = createOrderDto.ShopTableId,
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
                ShopTableId = updateOrderDto.ShopTableId,
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
        public IActionResult TotalOrderCount()
        {
            return Ok(_orderService.TTotalOrderCount());
        }

        [HttpGet("ActiveOrderCount")]
        public IActionResult ActiveOrderCount()
        {
            return Ok(_orderService.TActiveOrderCount());
        }

        [HttpGet("LastOrderPrice")]
        public IActionResult LastOrderPrice()
        {
            return Ok(_orderService.TLastOrderPrice());
        }

        [HttpGet("TodayTotalPrice")]
        public IActionResult TodayTotalPrice()
        {
            return Ok(_orderService.TTodayTotalPrice());
        }
    }
}
