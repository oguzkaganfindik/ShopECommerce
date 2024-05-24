using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        List<ResultBasketListWithProductsDto> TGetBasketListByBasketItemWithProductName(int id);
        List<Basket> TGetBasketByBasketItemNumber(int id);
        decimal TGetProductPrice(int productId);
        void TUpdateQuantity(int basketId, int newQuantity);
        Task<int> TGetBasketItemCountAsync();
    }
}
