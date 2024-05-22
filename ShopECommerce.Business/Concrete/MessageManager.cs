using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class MessageManager : IMessageService
    {
        private readonly IMessageDal _messageDal;

        public MessageManager(IMessageDal messageDal)
        {
            _messageDal = messageDal;
        }

        public async Task TMessageStatusApprovedAsync(int id)
        {
            await _messageDal.MessageStatusApprovedAsync(id);
        }

        public async Task TMessageStatusCancelledAsync(int id)
        {
            await _messageDal.MessageStatusCancelledAsync(id);
        }

        public void TAdd(Message entity)
        {
            _messageDal.Add(entity);
        }

        public void TDelete(Message entity)
        {
            _messageDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _messageDal.Delete(id);
        }

        public Message TGet(Expression<Func<Message, bool>> predicate)
        {
            return _messageDal.Get(predicate);
        }

        public IQueryable<Message> TGetAll(Expression<Func<Message, bool>> predicate = null)
        {
            return _messageDal.GetAll(predicate);
        }

        public Message TGetById(int id)
        {
            return _messageDal.GetById(id);
        }

        public List<Message> TGetListAll()
        {
            return _messageDal.GetListAll();
        }

        public IQueryable<Message> TGetListByStatusTrue(Expression<Func<Message, bool>> predicate = null)
        {
            return _messageDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _messageDal.ToggleStatus(id);
        }

        public void TUpdate(Message entity)
        {
            _messageDal.Update(entity);
        }

        public void THardDelete(int id)
        {
            _messageDal.HardDelete(id);
        }
    }
}
