using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfBannerDal : GenericRepository<Banner>, IBannerDal
    {
        private readonly ShopECommerceContext _context;

        public EfBannerDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }
    }
}