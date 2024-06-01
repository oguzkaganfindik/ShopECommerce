using ShopECommerce.DTOs.MessageDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        Task TAddAsync(CreateMessageDto createMessageDto);
        Task TMessageStatusApprovedAsync(int id);
        Task TMessageStatusCancelledAsync(int id);
        Task TDeleteMessageAndNotificationAsync(int id);
    }
}
