﻿using ShopECommerce.Data.Abstract;
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

        public List<Notification> GetAllNotificationsByFalse()
        {
            return _context.Notifications.Where(x => x.Status == false).ToList();
        }

        public void NotificationStatusChangeToFalse(int id)
        {
            var value = _context.Notifications.Find(id);
            value.Status = false;
            _context.SaveChanges();
        }

        public void NotificationStatusChangeToTrue(int id)
        {
            var value = _context.Notifications.Find(id);
            value.Status = true;
            _context.SaveChanges();
        }

        public int NotificationCountByStatusFalse()
        {
            return _context.Notifications.Where(x => x.Status == false).Count();
        }
    }
}