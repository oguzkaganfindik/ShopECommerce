using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
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

        public List<Basket> GetBasketByMenuTableNumber(int id)
        {
            var values = _context.Baskets.Where(x => x.MenuTableId == id).Include(y => y.Product).ToList();
            return values;
        }
    }
}
