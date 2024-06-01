using ShopECommerce.DTOs.NotificationDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface INotificationService : IGenericService<Notification>
    {
        Task TUpdateAsync(UpdateNotificationDto updateNotificationDto);
        Task TAddAsync(CreateNotificationDto createNotificationDto);
        Task<int> TNotificationCountByStatusFalseAsync();
        Task<List<Notification>> TGetAllNotificationsByTrueAsync();
        Task TNotificationStatusChangeToTrueAsync(int id);
        Task TNotificationStatusChangeToFalseAsync(int id);
    }
}
