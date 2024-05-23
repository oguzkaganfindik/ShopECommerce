using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        private readonly ShopECommerceContext _context;
        public EfDiscountDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task ChangeStatusToFalseAsync(int id)
        {
            var value = await _context.Discounts.FindAsync(id);
            if (value != null)
            {
                value.Status = false;
                await _context.SaveChangesAsync();
            }
        }

        public async Task ChangeStatusToTrueAsync(int id)
        {
            var value = await _context.Discounts.FindAsync(id);
            if (value != null)
            {
                value.Status = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Discount>> GetListByStatusTrueAsync()
        {
            return await _context.Discounts.Where(x => x.Status == true).ToListAsync();
        }
    }
}
