using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<int> CategoryCountAsync();
        Task<int> ActiveCategoryCountAsync();
        Task<int> PassiveCategoryCountAsync();
    }
}
