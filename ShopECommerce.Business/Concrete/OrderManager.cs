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

        public int TActiveOrderCount()
        {
            return _orderDal.ActiveOrderCount();
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

        public decimal TLastOrderPrice()
        {
            return _orderDal.LastOrderPrice();
        }

        public decimal TTodayTotalPrice()
        {
            return _orderDal.TodayTotalPrice();
        }

        public void TToggleStatus(int id)
        {
            _orderDal.ToggleStatus(id);
        }

        public int TTotalOrderCount()
        {
            return _orderDal.TotalOrderCount();
        }

        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
        }
    }
}
