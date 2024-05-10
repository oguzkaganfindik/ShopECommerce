using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class OrderDetailManager : IOrderDetailService
    {
        private readonly IOrderDetailDal _orderDetailDal;

        public OrderDetailManager(IOrderDetailDal orderDetailDal)
        {
            _orderDetailDal = orderDetailDal;
        }

        public void THardDelete(int id)
        {
            _orderDetailDal.HardDelete(id);
        }

        public void TAdd(OrderDetail entity)
        {
            _orderDetailDal.Add(entity);
        }

        public void TDelete(OrderDetail entity)
        {
            _orderDetailDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _orderDetailDal.Delete(id);
        }

        public OrderDetail TGet(Expression<Func<OrderDetail, bool>> predicate)
        {
            return _orderDetailDal.Get(predicate);
        }

        public IQueryable<OrderDetail> TGetAll(Expression<Func<OrderDetail, bool>> predicate = null)
        {
            return _orderDetailDal.GetAll(predicate);
        }

        public OrderDetail TGetById(int id)
        {
            return _orderDetailDal.GetById(id);
        }

        public List<OrderDetail> TGetListAll()
        {
            return _orderDetailDal.GetListAll();
        }

        public IQueryable<OrderDetail> TGetListByStatusTrue(Expression<Func<OrderDetail, bool>> predicate = null)
        {
            return _orderDetailDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _orderDetailDal.ToggleStatus(id);
        }

        public void TUpdate(OrderDetail entity)
        {
            _orderDetailDal.Update(entity);
        }
    }
}
