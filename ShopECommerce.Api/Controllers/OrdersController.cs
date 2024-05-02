using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;

        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
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

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _orderService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_orderService.TGetListByStatusTrue());
        }
    }
}
