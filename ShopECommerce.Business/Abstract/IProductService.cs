using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IProductService : IGenericService<Product>
    {
        //List<Product> TGetProductsWithCategories();
        List<ResultProductWithSubCategory> TGetProductsWithCategories();
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
    }
}
