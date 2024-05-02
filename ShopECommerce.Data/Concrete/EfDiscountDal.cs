using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfDiscountDal : GenericRepository<Discount>, IDiscountDal
    {
        private readonly ShopECommerceContext _context;
        public EfDiscountDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        //public void ChangeStatusToFalse(int id)
        //{
        //    var value = _context.Discounts.Find(id);
        //    value.Status = false;
        //    _context.SaveChanges();
        //}

        //public void ChangeStatusToTrue(int id)
        //{
        //    var value = _context.Discounts.Find(id);
        //    value.Status = true;
        //    _context.SaveChanges();
        //}

        //public List<Discount> GetListByStatusTrue()
        //{
        //    var value = _context.Discounts.Where(x => x.Status == true).ToList();
        //    return value;
        //}
    }
}
