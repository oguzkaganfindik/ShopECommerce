using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<ResultBasketListWithProductsDto> TGetBasketListByShopTableWithProductName(int id);
        List<Basket> TGetBasketByShopTableNumber(int id);
        decimal TGetProductPrice(int productId);
    }
}
