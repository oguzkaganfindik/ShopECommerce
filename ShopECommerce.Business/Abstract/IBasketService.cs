using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketService : IGenericService<Basket>
    {
        Task<List<ResultBasketListWithProductsDto>> TGetBasketListByBasketItemWithProductNameAsync(int id);
        Task<List<Basket>> TGetBasketByBasketItemNumberAsync(int id);
        Task<decimal> TGetProductPriceAsync(int productId);
        Task TUpdateQuantityAsync(int basketId, int newQuantity);
        Task<int> TGetBasketItemCountAsync();
    }
}
