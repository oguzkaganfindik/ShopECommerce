using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IShopTableService : IGenericService<ShopTable>
    {
        Task<int> TShopTableCountAsync();
    }
}
