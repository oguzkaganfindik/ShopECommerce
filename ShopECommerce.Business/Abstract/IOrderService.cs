using ShopECommerce.DTOs.OrderDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        Task TUpdateAsync(UpdateOrderDto updateOrderDto);
        Task TAddAsync(CreateOrderDto createOrderDto);
        Task<int> TTotalOrderCountAsync();
        Task<int> TActiveOrderCountAsync();
        Task<decimal> TLastOrderPriceAsync();
        Task<decimal> TTodayTotalPriceAsync();
    }
}
