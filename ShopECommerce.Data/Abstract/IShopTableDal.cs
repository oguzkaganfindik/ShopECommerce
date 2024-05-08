using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IShopTableDal : IGenericDal<ShopTable>
    {
        int ShopTableCount();
    }
}
