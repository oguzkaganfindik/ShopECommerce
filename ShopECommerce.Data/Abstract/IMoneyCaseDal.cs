using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IMoneyCaseDal : IGenericDal<MoneyCase>
    {
        Task<decimal> TotalMoneyCaseAmountAsync();
    }
}
