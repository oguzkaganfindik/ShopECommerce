using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketItemService : IGenericService<BasketItem>
    {
        Task<int> TBasketItemCountAsync();
    }
}
