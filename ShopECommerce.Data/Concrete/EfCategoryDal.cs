using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfCategoryDal : GenericRepository<Category>, ICategoryDal
    {
        private readonly ShopECommerceContext _context;
        public EfCategoryDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public int ActiveCategoryCount()
        {
            return _context.Categories.Where(x => x.Status == true).Count();
        }

        public int CategoryCount()
        {
            return _context.Categories.Count();
        }

        public int PassiveCategoryCount()
        {
            return _context.Categories.Where(x => x.Status == false).Count();
        }
    }
}
