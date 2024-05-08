using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfShopTableDal : GenericRepository<ShopTable>, IShopTableDal
    {
        private readonly ShopECommerceContext _context;
        public EfShopTableDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public int ShopTableCount()
        {
            return _context.ShopTables.Count();
        }
    }
}
