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

        public int ActiveSubCategoryCount()
        {
            return _context.SubCategories.Where(x => x.Status == true).Count();
        }

        public int SubCategoryCount()
        {
            return _context.SubCategories.Count();
        }

        public int PassiveSubCategoryCount()
        {
            return _context.SubCategories.Where(x => x.Status == false).Count();
        }

        public List<ResultSubCategoryWithCategory> GetSubCategoriesWithCategories()
        {
            var values = _context.SubCategories.Include(x => x.Category).Select(y => new ResultSubCategoryWithCategory
            {
                CategoryName = y.Category.CategoryName,
                SubCategoryName = y.SubCategoryName,
                Status = y.Status,
                Id = y.Id              
            }).ToList();

            return values;
        }
    }
}
