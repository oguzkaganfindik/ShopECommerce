using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IOrderDal : IGenericDal<Order>
    {
        Task<int> TotalOrderCountAsync();
        Task<int> ActiveOrderCountAsync();
        Task<decimal> LastOrderPriceAsync();
        Task<decimal> TodayTotalPriceAsync();
    }
}
