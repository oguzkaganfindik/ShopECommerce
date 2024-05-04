using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface ISubCategoryDal : IGenericDal<SubCategory>
    {
        int SubCategoryCount();
        int ActiveSubCategoryCount();
        int PassiveSubCategoryCount();

        List<ResultSubCategoryWithCategory> GetSubCategoriesWithCategories();
    }
}
