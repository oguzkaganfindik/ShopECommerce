using ShopECommerce.DTOs.CategoryDto;
using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ISubCategoryService : IGenericService<SubCategory>
    {
        Task TAddAsync(CreateSubCategoryDto createSubCategoryDto);
        Task TUpdateAsync(UpdateSubCategoryDto updateSubCategoryDto);
        Task<int> TSubCategoryCountAsync();
        Task<int> TActiveSubCategoryCountAsync();
        Task<int> TPassiveSubCategoryCountAsync();
        Task<List<ResultSubCategoryWithCategory>> TGetSubCategoriesWithCategoriesAsync();
    }
}
