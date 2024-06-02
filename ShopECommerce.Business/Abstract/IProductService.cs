using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        Task TUpdateAsync(UpdateProductDto updateProductDto);
        Task TAddAsync(CreateProductDto createProductDto);
        Task<List<ResultProductWithSubCategory>> TGetProductsWithSubCategoriesAsync();
        Task<int> TProductCountAsync();
        Task<int> TProductCountBySubCategoryNameAppleAsync();
        Task<int> TProductCountBySubCategoryNameTomatoAsync();
        Task<decimal> TProductPriceAvgAsync();
        Task<string> TProductNameByMaxPriceAsync();
        Task<string> TProductNameByMinPriceAsync();
        Task<decimal> TProductAvgPriceByAppleAsync();
        Task<decimal> TProductPriceByNativeOrangesAsync();
        Task<decimal> TTotalPriceByTomatoSubCategoryAsync();
        Task<decimal> TTotalPriceByStrawberrySubCategoryAsync();
        Task<List<ResultProductWithSubCategory>> TGetProductListByVegetableAsync();
        Task<List<ResultProductWithSubCategory>> TGetProductListByFruitesAsync();
        Task<GetProductShowcaseDetailDto> TGetProductShowcaseDetailIdAsync(int id);
    }
}
