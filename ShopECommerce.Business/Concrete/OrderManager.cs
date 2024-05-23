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

        public void THardDelete(int id)
        {
            _orderDal.HardDelete(id);
        }

        public Task<int> TActiveOrderCountAsync()
        {
            return _orderDal.ActiveOrderCountAsync();
        }

        public void TAdd(Order entity)
        {
            _orderDal.Add(entity);
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _orderDal.Delete(id);
        }

        public Order TGet(Expression<Func<Order, bool>> predicate)
        {
            return _orderDal.Get(predicate);
        }

        public IQueryable<Order> TGetAll(Expression<Func<Order, bool>> predicate = null)
        {
            return _orderDal.GetAll(predicate);
        }

        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
        }

        public List<Order> TGetListAll()
        {
            return _orderDal.GetListAll();
        }

        public IQueryable<Order> TGetListByStatusTrue(Expression<Func<Order, bool>> predicate = null)
        {
            return _orderDal.GetListByStatusTrue(predicate);
        }

        public async Task<decimal> TLastOrderPriceAsync()
        {
            return await _orderDal.LastOrderPriceAsync();
        }

        public Task<decimal> TTodayTotalPriceAsync()
        {
            return _orderDal.TodayTotalPriceAsync();
        }

        public void TToggleStatus(int id)
        {
            _orderDal.ToggleStatus(id);
        }

        public async Task<int> TTotalOrderCountAsync()
        {
            return await _orderDal.TotalOrderCountAsync();
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
