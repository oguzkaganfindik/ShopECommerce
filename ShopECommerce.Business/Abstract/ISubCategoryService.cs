using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ISubCategoryService : IGenericService<SubCategory>
    {
        int TSubCategoryCount();
        int TActiveSubCategoryCount();
        int TPassiveSubCategoryCount();

        List<ResultSubCategoryWithCategory> TGetSubCategoriesWithCategories();
    }
}
