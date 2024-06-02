using ShopECommerce.DTOs.OrderDetailDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IOrderDetailService : IGenericService<OrderDetail>
    {
        Task TUpdateAsync(UpdateOrderDetailDto updateOrderDetailDto);
        Task TAddAsync(CreateOrderDetailDto createOrderDetailDto);
    }
}
