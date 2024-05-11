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
                                  .Where(y => y.ShopTableId == id)
                                  .Include(x => x.Product)
                                  .Select(z => new ResultBasketListWithProductsDto
                                  {
                                      Id = z.Id,
                                      Price = z.Price,
                                      Count = z.Count,
                                      TotalPrice = z.TotalPrice,
                                      ProductId = z.Product.Id,
                                      ShopTableId = z.ShopTable.Id,
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
            // Sepet öğesini belirli Id'ye göre bul
            var basketItem = _context.Baskets.FirstOrDefault(x => x.Id == basketId);
            if (basketItem != null)
            {
                basketItem.Count = newQuantity;
                _context.Update(basketItem);
                _context.SaveChanges(); // Değişikliği kaydetmeyi unutmayın
            }
        }

        public async Task<int> GetBasketItemCount()
        {
            return await _context.Baskets.CountAsync(); // Veritabanında Baskets tablosundaki satır sayısını döndürür
        }
    }
}