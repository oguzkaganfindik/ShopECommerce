using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfMessageDal : GenericRepository<Message>, IMessageDal
    {
        private readonly ShopECommerceContext _context;
        public EfMessageDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public void MessageStatusApproved(int id)
        {
            var values = _context.Messages.Find(id);
            values.Description = "Mesaj Okundu";
            _context.SaveChanges();
        }

        public void MessageStatusCancelled(int id)
        {
            var values = _context.Messages.Find(id);
            values.Description = "Mesaj Kapatıldı";
            _context.SaveChanges();
        }
    }
}
