﻿using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IProductDal : IGenericDal<Product>
    {
        //List<Product> GetProductsWithSubCategories();
        List<ResultProductWithSubCategory> GetProductsWithSubCategories();
        int ProductCount();
        int ProductCountBySubCategoryNameHamburger();
        int ProductCountBySubCategoryNameDrink();
        decimal ProductPriceAvg();
        string ProductNameByMaxPrice();
        string ProductNameByMinPrice();
        decimal ProductAvgPriceByHamburger();
        decimal ProductPriceBySteakBurger();
        decimal TotalPriceByDrinkSubCategory();
        decimal TotalPriceBySaladSubCategory();
    }
}
