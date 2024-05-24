using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        Task<List<ResultBasketListWithProductsDto>> GetBasketListByBasketItemWithProductNameAsync(int id);
        Task<List<Basket>> GetBasketByBasketItemNumberAsync(int id);
        Task<decimal> GetProductPriceAsync(int productId);
        Task UpdateQuantityAsync(int basketId, int newQuantity);
        Task<int> GetBasketItemCountAsync();
    }
}
