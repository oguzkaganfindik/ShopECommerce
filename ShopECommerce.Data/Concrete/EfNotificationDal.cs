using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfNotificationDal : GenericRepository<Notification>, INotificationDal
    {
        private readonly ShopECommerceContext _context;
        public EfNotificationDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Notification>> GetAllNotificationsByTrueAsync()
        {
            return await _context.Notifications.Where(x => x.Status == true).ToListAsync();
        }

        public async Task NotificationStatusChangeToFalseAsync(int id)
        {
            var value = await _context.Notifications.FindAsync(id);
            if (value != null)
            {
                value.Status = false;
                await _context.SaveChangesAsync();
            }
        }

        public async Task NotificationStatusChangeToTrueAsync(int id)
        {
            var value = await _context.Notifications.FindAsync(id);
            if (value != null)
            {
                value.Status = true;
                await _context.SaveChangesAsync();
            }
        }

        public async Task<int> NotificationCountByStatusTrueAsync()
        {
            return await _context.Notifications.Where(x => x.Status == true).CountAsync();
        }
    }
}
