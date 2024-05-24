using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<ResultBasketListWithProductsDto> GetBasketListByBasketItemWithProductName(int id);
        List<Basket> GetBasketByBasketItemNumber(int id);
        decimal GetProductPrice(int productId);
        void UpdateQuantity(int basketId, int newQuantity);
        Task<int> GetBasketItemCountAsync();
    }
}
