using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        //List<Product> TGetProductsWithCategories();
        List<ResultProductWithSubCategory> TGetProductsWithSubCategories();
        int TProductCount();
        int TProductCountBySubCategoryNameHamburger();
        int TProductCountBySubCategoryNameDrink();
        decimal TProductPriceAvg();
        string TProductNameByMaxPrice();
        string TProductNameByMinPrice();
        decimal TProductAvgPriceByHamburger();
        decimal TProductPriceBySteakBurger();
        decimal TTotalPriceByDrinkSubCategory();
        decimal TTotalPriceBySaladSubCategory();
        List<ResultProductWithCategory> TGetProductListByVegetable();
        List<ResultProductWithCategory> TGetProductListByFruites();
        GetProductShowcaseDetailDto TGetProductShowcaseDetailId(int id);
    }
}
