using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        Task TChangeStatusToTrueAsync(int id);
        Task TChangeStatusToFalseAsync(int id);
        Task<List<Discount>> TGetListByStatusTrueAsync();
    }
}
