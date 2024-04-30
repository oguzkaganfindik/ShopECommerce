using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<ResultBasketListWithProductsDto> TGetBasketListByMenuTableWithProductName(int id);
        List<Basket> TGetBasketByMenuTableNumber(int id);
        decimal TGetProductPrice(int productId);
    }
}
