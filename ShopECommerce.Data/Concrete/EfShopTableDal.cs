using Microsoft.EntityFrameworkCore;
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

        public async Task<int> ShopTableCountAsync()
        {
            return await _context.ShopTables.CountAsync();
        }
    }
}
