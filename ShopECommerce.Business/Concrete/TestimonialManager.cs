using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class TestimonialManager : ITestimonialService
    {
        private readonly ITestimonialDal _testimonialDal;

        public TestimonialManager(ITestimonialDal testimonialDal)
        {
            _testimonialDal = testimonialDal;
        }

        public void THardDelete(int id)
        {
            _testimonialDal.HardDelete(id);
        }

        public void TAdd(Testimonial entity)
        {
            _testimonialDal.Add(entity);
        }

        public void TDelete(Testimonial entity)
        {
            _testimonialDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _testimonialDal.Delete(id);
        }

        public Testimonial TGet(Expression<Func<Testimonial, bool>> predicate)
        {
            return _testimonialDal.Get(predicate);
        }

        public IQueryable<Testimonial> TGetAll(Expression<Func<Testimonial, bool>> predicate = null)
        {
            return _testimonialDal.GetAll(predicate);
        }

        public Testimonial TGetById(int id)
        {
            return _testimonialDal.GetById(id);
        }

        public List<Testimonial> TGetListAll()
        {
            return _testimonialDal.GetListAll();
        }

        public IQueryable<Testimonial> TGetListByStatusTrue(Expression<Func<Testimonial, bool>> predicate = null)
        {
            return _testimonialDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _testimonialDal.ToggleStatus(id);
        }

        public void TUpdate(Testimonial entity)
        {
            _testimonialDal.Update(entity);
        }
    }
}
