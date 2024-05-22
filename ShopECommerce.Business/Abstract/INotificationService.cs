using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        Task<int> TNotificationCountByStatusFalseAsync();
        Task<List<Notification>> TGetAllNotificationsByTrueAsync();
        Task TNotificationStatusChangeToTrueAsync(int id);
        Task TNotificationStatusChangeToFalseAsync(int id);
    }
}
