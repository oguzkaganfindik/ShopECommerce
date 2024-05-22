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

        public async Task MessageStatusApprovedAsync(int id)
        {
            var values = await _context.Messages.FindAsync(id);
            values.Description = "Mesaj Okundu";
            await _context.SaveChangesAsync();
        }

        public async Task MessageStatusCancelledAsync(int id)
        {
            var values = await _context.Messages.FindAsync(id);
            values.Description = "Mesaj Kapatıldı";
            await _context.SaveChangesAsync();
        }
    }
}
