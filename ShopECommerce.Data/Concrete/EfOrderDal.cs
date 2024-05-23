using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfOrderDal : GenericRepository<Order>, IOrderDal
    {
        private readonly ShopECommerceContext _context;
        public EfOrderDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<int> ActiveOrderCountAsync()
        {
            return await _context.Orders.Where(x => x.Description == "Sipariş Verildi").CountAsync();
        }

        public async Task<decimal> LastOrderPriceAsync()
        {
            return await _context.Orders.OrderByDescending(x => x.Id).Take(1).Select(y => y.TotalPrice).FirstOrDefaultAsync();
        }

        public async Task<decimal> TodayTotalPriceAsync()
        {
            var today = DateTime.Now.Date;
            return await _context.Orders.Where(x => x.CreatedDate == today).SumAsync(y => y.TotalPrice);
        }

        public async Task<int> TotalOrderCountAsync()
        {
            return await _context.Orders.CountAsync();
        }
    }
}
