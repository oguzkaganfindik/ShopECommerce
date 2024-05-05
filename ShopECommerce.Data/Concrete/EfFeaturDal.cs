using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfFeaturDal : GenericRepository<Featur>, IFeaturDal
    {
        private readonly ShopECommerceContext _context;

        public EfFeaturDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }
    }
}