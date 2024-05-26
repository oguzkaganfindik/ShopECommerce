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

        public async Task TAddAsync(Message entity)
        {
            await _messageDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Message entity)
        {
            await _messageDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _messageDal.DeleteAsync(id);
        }

        public async Task<Message> TGetAsync(Expression<Func<Message, bool>> predicate)
        {
            return await _messageDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Message>> TGetAllAsync(Expression<Func<Message, bool>> predicate = null)
        {
            return await _messageDal.GetAllAsync(predicate);
        }

        public async Task<Message> TGetByIdAsync(int id)
        {
            return await _messageDal.GetByIdAsync(id);
        }

        public async Task<List<Message>> TGetListAllAsync()
        {
            return await _messageDal.GetListAllAsync();
        }

        public async Task<IQueryable<Message>> TGetListByStatusTrueAsync(Expression<Func<Message, bool>> predicate = null)
        {
            return await _messageDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _messageDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(Message entity)
        {
            await _messageDal.UpdateAsync(entity);
        }

        public async Task THardDeleteAsync(int id)
        {
            await _messageDal.HardDeleteAsync(id);
        }
    }
}
