using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        Task TMessageStatusApprovedAsync(int id);
        Task TMessageStatusCancelledAsync(int id);
    }
}
