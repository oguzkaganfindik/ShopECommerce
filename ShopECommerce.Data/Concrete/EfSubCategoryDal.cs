using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfSubCategoryDal : GenericRepository<SubCategory>, ISubCategoryDal
    {
        private readonly ShopECommerceContext _context;
        public EfSubCategoryDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ActiveSubCategoryCountAsync()
        {
            return await _context.SubCategories.Where(x => x.Status == true).CountAsync();
        }

        public async Task<int> SubCategoryCountAsync()
        {
            return await _context.SubCategories.CountAsync();
        }

        public async Task<int> PassiveSubCategoryCountAsync()
        {
            return await _context.SubCategories.Where(x => x.Status == false).CountAsync();
        }

        public async Task<List<ResultSubCategoryWithCategory>> GetSubCategoriesWithCategoriesAsync()
        {
            var values = await _context.SubCategories
                                        .Include(x => x.Category)
                                        .Select(y => new ResultSubCategoryWithCategory
                                        {
                                            CategoryName = y.Category.CategoryName,
                                            SubCategoryName = y.SubCategoryName,
                                            Status = y.Status,
                                            Id = y.Id
                                        })
                                        .ToListAsync();

            return values;
        }
    }
}
