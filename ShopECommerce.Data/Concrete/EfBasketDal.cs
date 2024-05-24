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

        public async Task<List<Basket>> GetBasketByBasketItemNumberAsync(int id)
        {
            var values = await _context.Baskets.Where(x => x.BasketItemId == id).Include(y => y.Product).ToListAsync();
            return values;
        }

        public async Task<List<ResultBasketListWithProductsDto>> GetBasketListByBasketItemWithProductNameAsync(int id)
        {
            var values = await _context.Baskets
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
                                        .ToListAsync();

            return values;
        }

        public async Task<decimal> GetProductPriceAsync(int productId)
        {
            return await _context.Products
                           .Where(x => x.Id == productId)
                           .Select(y => y.Price)
                           .FirstOrDefaultAsync();
        }

        public async Task UpdateQuantityAsync(int basketId, int newQuantity)
        {
            var basketItem = await _context.Baskets.FirstOrDefaultAsync(x => x.Id == basketId);
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