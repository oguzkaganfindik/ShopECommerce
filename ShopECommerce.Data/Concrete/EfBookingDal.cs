using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfBookingDal : GenericRepository<Booking>, IBookingDal
    {
        private readonly ShopECommerceContext _context;
        public EfBookingDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public void BookingStatusApproved(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Description = "Rezervasyon Onaylandı";
            _context.SaveChanges();
        }

        public void BookingStatusCancelled(int id)
        {
            var values = _context.Bookings.Find(id);
            values.Description = "Rezervasyon İptal Edildi";
            _context.SaveChanges();
        }
    }
}
