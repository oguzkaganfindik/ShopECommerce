using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IMessageDal : IGenericDal<Message>
    {
        Task MessageStatusApprovedAsync(int id);
        Task MessageStatusCancelledAsync(int id);
    }
}
