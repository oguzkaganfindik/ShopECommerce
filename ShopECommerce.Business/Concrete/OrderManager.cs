using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _orderDal.HardDeleteAsync(id);
        }

        public Task<int> TActiveOrderCountAsync()
        {
            return _orderDal.ActiveOrderCountAsync();
        }

        public async Task TAddAsync(Order entity)
        {
            await _orderDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Order entity)
        {
            await _orderDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _orderDal.DeleteAsync(id);
        }

        public async Task<Order> TGetAsync(Expression<Func<Order, bool>> predicate)
        {
            return await _orderDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Order>> TGetAllAsync(Expression<Func<Order, bool>> predicate = null)
        {
            return await _orderDal.GetAllAsync(predicate);
        }

        public async Task<Order> TGetByIdAsync(int id)
        {
            return await _orderDal.GetByIdAsync(id);
        }

        public async Task<List<Order>> TGetListAllAsync()
        {
            return await _orderDal.GetListAllAsync();
        }

        public async Task<IQueryable<Order>> TGetListByStatusTrueAsync(Expression<Func<Order, bool>> predicate = null)
        {
            return await _orderDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<decimal> TLastOrderPriceAsync()
        {
            return await _orderDal.LastOrderPriceAsync();
        }

        public Task<decimal> TTodayTotalPriceAsync()
        {
            return _orderDal.TodayTotalPriceAsync();
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _orderDal.ToggleStatusAsync(id);
        }

        public async Task<int> TTotalOrderCountAsync()
        {
            return await _orderDal.TotalOrderCountAsync();
        }

        public async Task TUpdateAsync(Order entity)
        {
            await _orderDal.UpdateAsync(entity);
        }
    }
}
