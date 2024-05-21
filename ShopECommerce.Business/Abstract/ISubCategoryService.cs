using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ISubCategoryService : IGenericService<SubCategory>
    {
        Task<int> TSubCategoryCountAsync();
        Task<int> TActiveSubCategoryCountAsync();
        Task<int> TPassiveSubCategoryCountAsync();

        Task<List<ResultSubCategoryWithCategory>> TGetSubCategoriesWithCategoriesAsync();
    }
}
