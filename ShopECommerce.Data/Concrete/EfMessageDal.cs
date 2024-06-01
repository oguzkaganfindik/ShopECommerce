using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        private readonly ShopECommerceContext _context;
        public EfMessageDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public async Task DeleteMessageAndNotificationAsync(int id)
        {
            var message = await _context.Messages.Include(m => m.Notification).FirstOrDefaultAsync(m => m.Id == id);
            if (message != null)
            {
                message.IsDeleted = true;
                message.Status = false;
                message.ModifiedDate = DateTime.Now;
                message.DeletedDate = DateTime.Now;

                if (message.Notification != null)
                {
                    message.Notification.IsDeleted = true;
                    message.Notification.Status = false;
                    message.Notification.ModifiedDate = DateTime.Now;
                    message.Notification.DeletedDate = DateTime.Now;
                }
                await _context.SaveChangesAsync();
            }
        }

        public async Task MessageStatusApprovedAsync(int id)
        {
            var message = await _context.Messages.Include(m => m.Notification).FirstOrDefaultAsync(m => m.Id == id);
            if (message != null)
            {
                message.Description = "Mesaj Okundu";
                if (message.Notification != null)
                {
                    message.Notification.IsDeleted = true;
                    message.Notification.Status = false;
                    message.Notification.ModifiedDate = DateTime.Now;
                    message.Notification.DeletedDate = DateTime.Now;
                }
                await _context.SaveChangesAsync();
            }
        }

        public async Task MessageStatusCancelledAsync(int id)
        {
            var message = await _context.Messages.Include(m => m.Notification).FirstOrDefaultAsync(m => m.Id == id);
            if (message != null)
            {
                message.Description = "Mesaj Kapatıldı";
                if (message.Notification != null)
                {
                    message.Notification.IsDeleted = true;
                    message.Notification.Status = false;
                    message.Notification.ModifiedDate = DateTime.Now;
                    message.Notification.DeletedDate = DateTime.Now;
                }
                await _context.SaveChangesAsync();
            }
        }
    }
}
