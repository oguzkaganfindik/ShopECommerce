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

        //public List<Product> GetProductsWithCategories()
        //{
        //    var values = _context.Products.Include(x => x.Category).ToList();
        //    return values;
        //}

        public int ProductCount()
        {
            return _context.Products.Count();
        }

        public int ProductCountByCategoryNameDrink()
        {
            return _context.Products.Where(x => x.CategoryId == _context.Categories.Where(y => y.CategoryName == "içecek").Select(z => z.Id).FirstOrDefault()).Count();
        }

        public int ProductCountByCategoryNameHamburger()
        {
            return _context.Products.Where(x => x.CategoryId == _context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.Id).FirstOrDefault()).Count();
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
            return _context.Products.Where(x => x.CategoryId == _context.Categories.Where(y => y.CategoryName == "Hamburger").Select(z => z.Id).FirstOrDefault()).Average(w => w.Price);
        }

        public decimal ProductPriceBySteakBurger()
        {

            return _context.Products.Where(x => x.ProductName == "Steak Burger").Select(y => y.Price).FirstOrDefault();

        }

        public decimal TotalPriceByDrinkCategory()
        {
            int id = _context.Categories.Where(x => x.CategoryName == "içecek").Select(y => y.Id).FirstOrDefault();
            return _context.Products.Where(x => x.CategoryId == id).Sum(y => y.Price);
        }

        public decimal TotalPriceBySaladCategory()
        {
            int id = _context.Categories.Where(x => x.CategoryName == "Salata").Select(y => y.Id).FirstOrDefault();
            return _context.Products.Where(x => x.CategoryId == id).Sum(y => y.Price);
        }

        public List<ResultProductWithCategory> GetProductsWithCategories()
        {
            var values = _context.Products.Include(x => x.Category).Select(y => new ResultProductWithCategory
            {
                Description = y.Description,
                ImageUrl = y.ImageUrl,
                Price = y.Price,
                Id = y.Id,
                ProductName = y.ProductName,
                ProductStatus = y.ProductStatus,
                CategoryName = y.Category.CategoryName
            }).ToList();

            return values;
        }
    }
}
