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

        public int ProductCountBySubCategoryNameDrink()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "içecek").Select(z => z.Id).FirstOrDefault()).Count();
        }

        public int ProductCountBySubCategoryNameHamburger()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "Hamburger").Select(z => z.Id).FirstOrDefault()).Count();
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

        public decimal ProductAvgPriceByHamburger()
        {
            return _context.Products.Where(x => x.SubCategoryId == _context.SubCategories.Where(y => y.SubCategoryName == "Hamburger").Select(z => z.Id).FirstOrDefault()).Average(w => w.Price);
        }

        public decimal ProductPriceBySteakBurger()
        {

            return _context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();

        }

        public decimal TotalPriceByDrinkSubCategory()
        {
            int id = _context.SubCategories.Where(x => x.SubCategoryName == "içecek").Select(y => y.Id).FirstOrDefault();
            return _context.Products.Where(x => x.SubCategoryId == id).Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladSubCategory()
        {
            int id = _context.SubCategories.Where(x => x.SubCategoryName == "Salata").Select(y => y.Id).FirstOrDefault();
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
                ImageUrl = y.ImageUrl,
                SubCategoryName = y.SubCategory.SubCategoryName,
                CategoryName = y.SubCategory.Category.CategoryName,
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
                                ImageUrl = y.ImageUrl,
                                SubCategoryName = y.SubCategory.SubCategoryName,
                                CategoryName = y.SubCategory.Category.CategoryName,
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
                                ImageUrl = y.ImageUrl,
                                SubCategoryName = y.SubCategory.SubCategoryName,
                                CategoryName = y.SubCategory.Category.CategoryName,
                                Status = y.Status
                            })
                            .ToList();

            return values;
        }
    }
}

