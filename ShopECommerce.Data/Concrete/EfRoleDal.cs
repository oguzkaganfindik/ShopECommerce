using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfRoleDal : GenericRepository<Role>, IRoleDal
    {
        private readonly ShopECommerceContext _context;

        public EfRoleDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }
    }
}