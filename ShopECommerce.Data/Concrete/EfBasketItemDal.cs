using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfBasketItemDal : GenericRepository<BasketItem>, IBasketItemDal
    {
        private readonly ShopECommerceContext _context;
        public EfBasketItemDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> BasketItemCountAsync()
        {
            return await _context.BasketItems.CountAsync();
        }
    }
}
