using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface INotificationDal : IGenericDal<Notification>
    {
        Task<int> NotificationCountByStatusTrueAsync();
        Task<List<Notification>> GetAllNotificationsByTrueAsync();
        Task NotificationStatusChangeToTrueAsync(int id);
        Task NotificationStatusChangeToFalseAsync(int id);
    }
}
