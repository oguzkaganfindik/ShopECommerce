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
        public IActionResult OrderDetailList()
        {
            var value = _mapper.Map<List<ResultOrderDetailDto>>(_orderDetailService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateOrderDetail(CreateOrderDetailDto createOrderDetailDto)
        {
            _orderDetailService.TAdd(new OrderDetail()
            {
                OrderId = createOrderDetailDto.OrderId,
                ProductId = createOrderDetailDto.ProductId,
                Count = createOrderDetailDto.Count,
                TotalPrice = createOrderDetailDto.TotalPrice,
                UnitPrice = createOrderDetailDto.UnitPrice
            });

            return Ok("Hakkımda Kısmı Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteOrderDetail(int id)
        {
            var value = _orderDetailService.TGetById(id);
            _orderDetailService.TDelete(value);
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetOrderDetail(int id)
        {
            var value = _orderDetailService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateOrderDetail(UpdateOrderDetailDto updateOrderDetailDto)
        {
            _orderDetailService.TUpdate(new OrderDetail()
            {
                Id = updateOrderDetailDto.OrderId,
                OrderId = updateOrderDetailDto.OrderId,
                ProductId = updateOrderDetailDto.ProductId,
                Count = updateOrderDetailDto.Count,
                TotalPrice = updateOrderDetailDto.TotalPrice,
                UnitPrice = updateOrderDetailDto.UnitPrice
            });

            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _orderDetailService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultOrderDetailDto>>(_orderDetailService.TGetListByStatusTrue());
            return Ok(value);
        }
    }
}
