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

        //public List<Product> GetProductsWithSubCategories()
        //{
        //    var values = _context.Products.Include(x => x.SubCategory).ToList();
        //    return values;
        //}

        public int ProductCount()
        {
            return _context.Products.Count();
        }

        public int ProductCountBySubCategoryNameTomato()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "tomato").Select(z => z.Id).FirstOrDefault()).Count();
        }

        public int ProductCountBySubCategoryNameApple()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "Apple").Select(z => z.Id).FirstOrDefault()).Count();
        }

        public string ProductNameByMaxPrice()
        {
            return _context.Products.Where(x => x.Price == _context.Products.Max(y => y.Price)).Select(z => z.ProductName).FirstOrDefault();
        }

        public string ProductNameByMinPrice()
        {
            return _context.Products.Where(x => x.Price == _context.Products.Min(y => y.Price)).Select(z => z.ProductName).FirstOrDefault();
        }

        public decimal ProductPriceAvg()
        {

            return _context.Products.Average(x => x.Price);

        }

        public decimal ProductAvgPriceByApple()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "Apple").Select(z => z.Id).FirstOrDefault()).Average(w => w.Price);
        }

        public decimal ProductPriceByNativeOranges()
        {

            return _context.Products.Where(x => x.ProductName == "Native Oranges").Select(y => y.Price).FirstOrDefault();

        }

        public decimal TotalPriceByTomatoSubCategory()
        {
            int id = _context.SubCategories.Where(x => x.SubCategoryName == "Tomato").Select(y => y.Id).FirstOrDefault();
            return _context.Products.Where(x => x.SubCategoryId == id).Sum(y => y.Price);
        }

        public decimal TotalPriceByStrawberrySubCategory()
        {
            int id = _context.SubCategories.Where(x => x.SubCategoryName == "Strawberry").Select(y => y.Id).FirstOrDefault();
            return _context.Products.Where(x => x.SubCategoryId == id).Sum(y => y.Price);
        }

        public List<ResultProductWithSubCategory> GetProductsWithSubCategories()
        {
            var values = _context.Products.Include(x => x.SubCategory).Include(x => x.SubCategory.Category).Select(y => new ResultProductWithSubCategory
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
            }).ToList();

            return values;
        }

        public List<ResultProductWithCategory> GetProductListByVegetable()
        {
            var values = _context.Products
                            .Where(x => x.SubCategory.Category.CategoryName == "Vesitables")
                            .Select(y => new ResultProductWithCategory
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
                            .ToList();

            return values;
        }

        public List<ResultProductWithCategory> GetProductListByFruites()
        {
            var values = _context.Products
                            .Where(x => x.SubCategory.Category.CategoryName == "Fruites")
                            .Select(y => new ResultProductWithCategory
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
                            .ToList();

            return values;
        }

        public GetProductShowcaseDetailDto GetProductShowcaseDetailId(int id)
        {
            var value = _context.Products
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
                .FirstOrDefault();

            return value;
        }
    }
}

