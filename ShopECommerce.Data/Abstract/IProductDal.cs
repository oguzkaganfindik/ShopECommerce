using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        Task<List<ResultProductWithSubCategory>> GetProductsWithSubCategoriesAsync();
        Task<int> ProductCountAsync();
        Task<int> ProductCountBySubCategoryNameAppleAsync();
        Task<int> ProductCountBySubCategoryNameTomatoAsync();
        Task<decimal> ProductPriceAvgAsync();
        Task<string> ProductNameByMaxPriceAsync();
        Task<string> ProductNameByMinPriceAsync();
        Task<decimal> ProductAvgPriceByAppleAsync();
        Task<decimal> ProductPriceByNativeOrangesAsync();
        Task<decimal> TotalPriceByTomatoSubCategoryAsync();
        Task<decimal> TotalPriceByStrawberrySubCategoryAsync();
        Task<List<ResultProductWithSubCategory>> GetProductListByVegetableAsync();
        Task<List<ResultProductWithSubCategory>> GetProductListByFruitesAsync();
        Task<GetProductShowcaseDetailDto> GetProductShowcaseDetailAsync(int id);
    }
}
