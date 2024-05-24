using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IBasketItemDal : IGenericDal<BasketItem>
    {
        Task<int> BasketItemCountAsync();
    }
}
