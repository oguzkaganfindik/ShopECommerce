using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class BookingManager : IBookingService
    {
        private readonly IBookingDal _bookingDal;

        public BookingManager(IBookingDal bookingDal)
        {
            _bookingDal = bookingDal;
        }

        public void BookingStatusApproved(int id)
        {
            _bookingDal.BookingStatusApproved(id);
        }

        public void BookingStatusCancelled(int id)
        {
            _bookingDal.BookingStatusCancelled(id);
        }

        public List<Booking> TGetListAll()
        {
            return _bookingDal.GetListAll();
        }

        public void TAdd(Booking entity)
        {
            _bookingDal.Add(entity);
        }

        public void TDelete(Booking entity)
        {
            _bookingDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _bookingDal.Delete(id);
        }

        public Booking TGet(Expression<Func<Booking, bool>> predicate)
        {
            return _bookingDal.Get(predicate);
        }

        public IQueryable<Booking> TGetAll(Expression<Func<Booking, bool>> predicate = null)
        {
            return _bookingDal.GetAll(predicate);
        }

        public Booking TGetById(int id)
        {
            return _bookingDal.GetById(id);
        }
        
        public void TUpdate(Booking entity)
        {
            _bookingDal.Update(entity);
        }

        public void TToggleStatus(int id)
        {
            _bookingDal.ToggleStatus(id);
        }

        public IQueryable<Booking> TGetListByStatusTrue(Expression<Func<Booking, bool>> predicate = null)
        {
            return _bookingDal.GetListByStatusTrue(predicate);
        }
    }
}
