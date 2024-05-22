using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IMoneyCaseService : IGenericService<MoneyCase>
    {
        Task<decimal> TTotalMoneyCaseAmountAsync();
    }
}
