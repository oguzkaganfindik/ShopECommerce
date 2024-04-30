using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IBasketDal : IGenericDal<Basket>
    {
        List<ResultBasketListWithProductsDto> GetBasketListByMenuTableWithProductName(int id);
        List<Basket> GetBasketByMenuTableNumber(int id);
        decimal GetProductPrice(int productId);
    }
}
