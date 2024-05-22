using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private readonly INotificationDal _notificationDal;
        public NotificationManager(INotificationDal notificationDal)
        {
            _notificationDal = notificationDal;
        }

        public void TAdd(Notification entity)
        {
            _notificationDal.Add(entity);
        }

        public void TDelete(Notification entity)
        {
            _notificationDal.Delete(entity);
        }

        async Task<List<Notification>> INotificationService.TGetAllNotificationsByTrueAsync()
        {
            return await _notificationDal.GetAllNotificationsByTrueAsync();
        }

        public Notification TGetById(int id)
        {
            return _notificationDal.GetById(id);
        }

        public List<Notification> TGetListAll()
        {
            return _notificationDal.GetListAll();
        }

        public async Task TNotificationStatusChangeToFalseAsync(int id)
        {
            await _notificationDal.NotificationStatusChangeToFalseAsync(id);
        }

        public async Task TNotificationStatusChangeToTrueAsync(int id)
        {
            await _notificationDal.NotificationStatusChangeToTrueAsync(id);
        }

        public async Task<int> TNotificationCountByStatusFalseAsync()
        {
            return await _notificationDal.NotificationCountByStatusTrueAsync();
        }

        public void TUpdate(Notification entity)
        {
            _notificationDal.Update(entity);
        }

        public void TDelete(int id)
        {
            _notificationDal.Delete(id);
        }

        public Notification TGet(Expression<Func<Notification, bool>> predicate)
        {
            return _notificationDal.Get(predicate);
        }

        public IQueryable<Notification> TGetAll(Expression<Func<Notification, bool>> predicate = null)
        {
            return _notificationDal.GetAll(predicate);
        }

        public void TToggleStatus(int id)
        {
            _notificationDal.ToggleStatus(id);
        }

        public IQueryable<Notification> TGetListByStatusTrue(Expression<Func<Notification, bool>> predicate = null)
        {
            return _notificationDal.GetListByStatusTrue(predicate);
        }

        public void THardDelete(int id)
        {
            _notificationDal.HardDelete(id);
        }
    }
}
