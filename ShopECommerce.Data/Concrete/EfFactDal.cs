using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfFactDal : GenericRepository<Fact>, IFactDal
    {
        private readonly ShopECommerceContext _context;

        public EfFactDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }
    }
}