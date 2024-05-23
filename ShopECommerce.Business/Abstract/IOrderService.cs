using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IOrderService : IGenericService<Order>
    {
        Task<int> TTotalOrderCountAsync();
        Task<int> TActiveOrderCountAsync();
        Task<decimal> TLastOrderPriceAsync();
        Task<decimal> TTodayTotalPriceAsync();
    }
}
