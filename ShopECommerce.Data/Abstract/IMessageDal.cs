using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        void MessageStatusApproved(int id);
        void MessageStatusCancelled(int id);
    }
}
