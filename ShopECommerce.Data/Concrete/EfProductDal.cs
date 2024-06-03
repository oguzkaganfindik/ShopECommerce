using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        private readonly ShopECommerceContext _context;
        public EfProductDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ProductCountAsync()
        {
            return await _context.Products.CountAsync();
        }


        public async Task<int> ProductCountBySubCategoryNameTomatoAsync()
        {
            int subCategoryId = await _context.SubCategories
                                              .Where(y => y.SubCategoryName == "Tomato")
                                              .Select(z => z.Id)
                                              .FirstOrDefaultAsync();

            return await _context.Products
                                 .Where(x => x.SubCategoryId == subCategoryId)
                                 .CountAsync();
        }


        public async Task<int> ProductCountBySubCategoryNameAppleAsync()
        {
            int subCategoryId = await _context.SubCategories
                                              .Where(y => y.SubCategoryName == "Apple")
                                              .Select(z => z.Id)
                                              .FirstOrDefaultAsync();

            return await _context.Products
                                 .Where(x => x.SubCategoryId == subCategoryId)
                                 .CountAsync();
        }


        public async Task<string> ProductNameByMaxPriceAsync()
        {
            var maxPrice = await _context.Products.MaxAsync(y => y.Price);
            return await _context.Products
                                 .Where(x => x.Price == maxPrice)
                                 .Select(z => z.ProductName)
                                 .FirstOrDefaultAsync();
        }

        public async Task<string> ProductNameByMinPriceAsync()
        {
            var minPrice = await _context.Products.MinAsync(y => y.Price);
            return await _context.Products
                                 .Where(x => x.Price == minPrice)
                                 .Select(z => z.ProductName)
                                 .FirstOrDefaultAsync();
        }


        public async Task<decimal> ProductPriceAvgAsync()
        {
            return await _context.Products
                                 .AverageAsync(x => x.Price);
        }


        public async Task<decimal> ProductAvgPriceByAppleAsync()
        {
            int subCategoryId = await _context.SubCategories
                                              .Where(y => y.SubCategoryName == "Apple")
                                              .Select(z => z.Id)
                                              .FirstOrDefaultAsync();

            return await _context.Products
                                 .Where(x => x.SubCategoryId == subCategoryId)
                                 .AverageAsync(w => w.Price);
        }

        public async Task<decimal> ProductPriceByNativeOrangesAsync()
        {
            return await _context.Products
                                 .Where(x => x.ProductName == "Native Oranges")
                                 .Select(y => y.Price)
                                 .FirstOrDefaultAsync();
        }

        public async Task<decimal> TotalPriceByTomatoSubCategoryAsync()
        {
            int id = await _context.SubCategories
                                   .Where(x => x.SubCategoryName == "Tomato")
                                   .Select(y => y.Id)
                                   .FirstOrDefaultAsync();

            return await _context.Products
                                 .Where(x => x.SubCategoryId == id)
                                 .SumAsync(y => y.Price);
        }

        public async Task<decimal> TotalPriceByStrawberrySubCategoryAsync()
        {
            int id = await _context.SubCategories
                                   .Where(x => x.SubCategoryName == "Strawberry")
                                   .Select(y => y.Id)
                                   .FirstOrDefaultAsync();

            return await _context.Products
                                 .Where(x => x.SubCategoryId == id)
                                 .SumAsync(y => y.Price);
        }

        public async Task<List<ResultProductWithSubCategory>> GetProductsWithSubCategoriesAsync()
        {
            var values = await _context.Products
                .Include(x => x.SubCategory)
                .ThenInclude(subCategory => subCategory.Category)
                .Select(y => new ResultProductWithSubCategory
                {
                    Id = y.Id,
                    ProductName = y.ProductName,
                    Description = y.Description,
                    Price = y.Price,
                    ImagePath = y.ImagePath,
                    SubCategoryName = y.SubCategory.SubCategoryName,
                    CategoryName = y.SubCategory.Category.CategoryName,
                    ProductTitle = y.ProductTitle,
                    Status = y.Status
                })
                .ToListAsync();

            return values;
        }

        public async Task<List<ResultProductWithSubCategory>> GetProductListByVegetableAsync()
        {
            var values = await _context.Products
                .Where(x => x.SubCategory.Category.CategoryName == "Vesitables")
                .Select(y => new ResultProductWithSubCategory
                {
                    Id = y.Id,
                    ProductName = y.ProductName,
                    Description = y.Description,
                    Price = y.Price,
                    ImagePath = y.ImagePath,
                    SubCategoryName = y.SubCategory.SubCategoryName,
                    CategoryName = y.SubCategory.Category.CategoryName,
                    ProductTitle = y.ProductTitle,
                    Status = y.Status
                })
                .ToListAsync();

            return values;
        }

        public async Task<List<ResultProductWithSubCategory>> GetProductListByFruitesAsync()
        {
            var values = await _context.Products
                .Where(x => x.SubCategory.Category.CategoryName == "Fruites")
                .Select(y => new ResultProductWithSubCategory
                {
                    Id = y.Id,
                    ProductName = y.ProductName,
                    Description = y.Description,
                    Price = y.Price,
                    ImagePath = y.ImagePath,
                    SubCategoryName = y.SubCategory.SubCategoryName,
                    CategoryName = y.SubCategory.Category.CategoryName,
                    ProductTitle = y.ProductTitle,
                    Status = y.Status
                })
                .ToListAsync();

            return values;
        }

        public async Task<GetProductShowcaseDetailDto> GetProductShowcaseDetailAsync(int id)
        {
            var value = await _context.Products
                .Where(p => p.Id == id)
                .Select(p => new GetProductShowcaseDetailDto
                {
                    Id = p.Id,
                    ProductName = p.ProductName,
                    Description = p.Description,
                    Price = p.Price,
                    ImagePath = p.ImagePath,
                    SubCategoryName = p.SubCategory.SubCategoryName,
                    CategoryName = p.SubCategory.Category.CategoryName,
                    Status = p.Status,
                    ProductTitle = p.ProductTitle,
                    Weight = p.Weight,
                    CountryOfOrigin = p.CountryOfOrigin,
                    Quality = p.Quality,
                    Сheck = p.Сheck,
                    MinWeight = p.MinWeight
                })
                .FirstOrDefaultAsync();

            return value;
        }
    }
}