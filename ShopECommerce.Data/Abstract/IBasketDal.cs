using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<ResultBasketListWithProductsDto> GetBasketListByShopTableWithProductName(int id);
        List<Basket> GetBasketByShopTableNumber(int id);
        decimal GetProductPrice(int productId);
    }
}
