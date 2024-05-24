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

        public List<Basket> GetBasketByBasketItemNumber(int id)
        {
            var values = _context.Baskets.Where(x => x.BasketItemId == id).Include(y => y.Product).ToList();
            return values;
        }

        public List<ResultBasketListWithProductsDto> GetBasketListByBasketItemWithProductName(int id)
        {
            var values = _context.Baskets                            
                                  .Where(y => y.BasketItemId == id)
                                  .Include(x => x.Product)
                                  .Select(z => new ResultBasketListWithProductsDto
                                  {
                                      Id = z.Id,
                                      Price = z.Price,
                                      Count = z.Count,
                                      TotalPrice = z.TotalPrice,
                                      ProductId = z.Product.Id,
                                      BasketItemId = z.BasketItem.Id,
                                      ProductName = z.Product.ProductName,
                                      ImagePath = z.Product.ImagePath
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

        public void UpdateQuantity(int basketId, int newQuantity)
        {
            var basketItem = _context.Baskets.FirstOrDefault(x => x.Id == basketId);
            if (basketItem != null)
            {
                basketItem.Count = newQuantity;
                _context.Update(basketItem);
                _context.SaveChanges(); 
            }
        }

        public async Task<int> GetBasketItemCountAsync()
        {
            return await _context.Baskets.CountAsync();
        }
    }
}