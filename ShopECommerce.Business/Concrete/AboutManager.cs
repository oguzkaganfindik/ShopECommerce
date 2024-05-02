using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public void TAdd(About entity)
        {
            _aboutDal.Add(entity);
        }

        public void TDelete(About entity)
        {
            _aboutDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _aboutDal.Delete(id);
        }

        public About TGet(Expression<Func<About, bool>> predicate)
        {
            return _aboutDal.Get(predicate);
        }

        public IQueryable<About> TGetAll(Expression<Func<About, bool>> predicate = null)
        {
            return _aboutDal.GetAll(predicate);
        }

        public About TGetById(int id)
        {
            return _aboutDal.GetById(id);
        }

        public List<About> TGetListAll()
        {
            return _aboutDal.GetListAll();
        }

        public IQueryable<About> TGetListByStatusTrue(Expression<Func<About, bool>> predicate = null)
        {
            return _aboutDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _aboutDal.ToggleStatus(id);
        }

        public void TUpdate(About entity)
        {
            _aboutDal.Update(entity);
        }
    }
}
