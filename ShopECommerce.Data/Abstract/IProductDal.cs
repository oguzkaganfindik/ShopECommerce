using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        List<ResultProductWithSubCategory> GetProductsWithSubCategories();
        int ProductCount();
        int ProductCountBySubCategoryNameApple();
        int ProductCountBySubCategoryNameTomato();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByApple();
        decimal ProductPriceByNativeOranges();
        decimal TotalPriceByTomatoSubCategory();
        decimal TotalPriceByStrawberrySubCategory();
        List<ResultProductWithSubCategory> GetProductListByVegetable();
        List<ResultProductWithSubCategory> GetProductListByFruites();
        GetProductShowcaseDetailDto GetProductShowcaseDetailId(int id);
    }
}
