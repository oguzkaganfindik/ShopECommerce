using ShopECommerce.DTOs.AboutDto;
using ShopECommerce.DTOs.CategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ICategoryService : IGenericService<Category>
    {
        Task TAddAsync(CreateCategoryDto createCategoryDto);
        Task TUpdateAsync(UpdateCategoryDto updateCategoryDto);
        Task<int> TCategoryCountAsync();
        Task<int> TActiveCategoryCountAsync();
        Task<int> TPassiveCategoryCountAsync();
    }
}
