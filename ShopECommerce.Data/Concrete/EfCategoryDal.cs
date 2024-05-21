using Microsoft.EntityFrameworkCore;
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

        public async Task<int> ActiveCategoryCountAsync()
        {
            return await _context.Categories.Where(x => x.Status).CountAsync();
        }

        public async Task<int> CategoryCountAsync()
        {
            return await _context.Categories.CountAsync();
        }

        public async Task<int> PassiveCategoryCountAsync()
        {
            return await _context.Categories.Where(x => !x.Status).CountAsync();
        }
    }
}
