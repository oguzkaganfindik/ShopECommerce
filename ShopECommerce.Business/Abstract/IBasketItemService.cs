using ShopECommerce.DTOs.BasketItemDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBasketItemService : IGenericService<BasketItem>
    {
        Task TUpdateAsync(UpdateBasketItemDto updateBasketItemDto);
        Task TAddAsync(CreateBasketItemDto createBasketItemDto);
        Task<int> TBasketItemCountAsync();
    }
}