using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        List<ResultProductWithSubCategory> TGetProductsWithSubCategories();
        int TProductCount();
        int TProductCountBySubCategoryNameApple();
        int TProductCountBySubCategoryNameTomato();
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductAvgPriceByApple();
        decimal TProductPriceByNativeOranges();
        decimal TTotalPriceByTomatoSubCategory();
        decimal TTotalPriceByStrawberrySubCategory();
        List<ResultProductWithSubCategory> TGetProductListByVegetable();
        List<ResultProductWithSubCategory> TGetProductListByFruites();
        GetProductShowcaseDetailDto TGetProductShowcaseDetailId(int id);
    }
}
