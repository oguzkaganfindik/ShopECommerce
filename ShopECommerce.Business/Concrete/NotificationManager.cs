using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.NotificationDto;
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

        public async Task TAddAsync(Notification entity)
        {
            await _notificationDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Notification entity)
        {
            await _notificationDal.DeleteAsync(entity);
        }

        async Task<List<Notification>> INotificationService.TGetAllNotificationsByTrueAsync()
        {
            return await _notificationDal.GetAllNotificationsByTrueAsync();
        }

        public async Task<Notification> TGetByIdAsync(int id)
        {
            return await _notificationDal.GetByIdAsync(id);
        }

        public async Task<List<Notification>> TGetListAllAsync()
        {
            return await _notificationDal.GetListAllAsync();
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

        public async Task TUpdateAsync(Notification entity)
        {
            await _notificationDal.UpdateAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _notificationDal.DeleteAsync(id);
        }

        public async Task<Notification> TGetAsync(Expression<Func<Notification, bool>> predicate)
        {
            return await _notificationDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Notification>> TGetAllAsync(Expression<Func<Notification, bool>> predicate = null)
        {
            return await _notificationDal.GetAllAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _notificationDal.ToggleStatusAsync(id);
        }

        public async Task<IQueryable<Notification>> TGetListByStatusTrueAsync(Expression<Func<Notification, bool>> predicate = null)
        {
            return await _notificationDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task THardDeleteAsync(int id)
        {
            await _notificationDal.HardDeleteAsync(id);
        }
        public async Task TUpdateAsync(UpdateNotificationDto updateNotificationDto)
        {
            var notification = await _notificationDal.GetByIdAsync(updateNotificationDto.Id);
            if (notification == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            notification.Description = updateNotificationDto.Description;
            notification.Icon = updateNotificationDto.Icon;
            notification.Status = updateNotificationDto.Status;
            notification.Type = updateNotificationDto.Type;

            await _notificationDal.UpdateAsync(notification);
        }

        public async Task TAddAsync(CreateNotificationDto createNotificationDto)
        {
            await _notificationDal.AddAsync(new Notification()
            {
                Description = createNotificationDto.Description,
                Icon = createNotificationDto.Icon,
                Status = createNotificationDto.Status,
                Type = createNotificationDto.Type
            });
        }
    }
}
