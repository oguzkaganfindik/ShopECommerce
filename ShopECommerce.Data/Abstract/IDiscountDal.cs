using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IDiscountDal : IGenericDal<Discount>
    {
        Task ChangeStatusToTrueAsync(int id);
        Task ChangeStatusToFalseAsync(int id);
        Task<List<Discount>> GetListByStatusTrueAsync();
    }
}
