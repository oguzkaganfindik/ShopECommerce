using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IMessageService : IGenericService<Message>
    {
        void TMessageStatusApproved(int id);
        void TMessageStatusCancelled(int id);
    }
}
