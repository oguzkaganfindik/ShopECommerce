using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfBasketDal : GenericRepository<Basket>, IBasketDal
    {
        private readonly ShopECommerceContext _context;
        public EfBasketDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public List<Basket> GetBasketByShopTableNumber(int id)
        {
            var values = _context.Baskets.Where(x => x.ShopTableId == id).Include(y => y.Product).ToList();
            return values;
        }

        public List<ResultBasketListWithProductsDto> GetBasketListByShopTableWithProductName(int id)
        {
            var values = _context.Baskets
                                  .Include(x => x.Product)
                                  .Where(y => y.ShopTableId == id)
                                  .Select(z => new ResultBasketListWithProductsDto
                                  {
                                      BasketId = z.Id,
                                      Count = z.Count,
                                      ShopTableId = z.ShopTableId,
                                      Price = z.Price,
                                      ProductId = z.ProductId,
                                      TotalPrice = z.TotalPrice,
                                      ProductName = z.Product.ProductName
                                  })
                                  .ToList();

            return values;
        }

        public decimal GetProductPrice(int productId)
        {
            return _context.Products
                           .Where(x => x.Id == productId)
                           .Select(y => y.Price)
                           .FirstOrDefault();
        }
    }
}
