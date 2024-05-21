using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task<int> TCategoryCountAsync();
        Task<int> TActiveCategoryCountAsync();
        Task<int> TPassiveCategoryCountAsync();
    }
}
