using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface ISubCategoryDal : IGenericDal<SubCategory>
    {
        Task<int> SubCategoryCountAsync();
        Task<int> ActiveSubCategoryCountAsync();
        Task<int> PassiveSubCategoryCountAsync();
        Task<List<ResultSubCategoryWithCategory>> GetSubCategoriesWithCategoriesAsync();
    }
}
