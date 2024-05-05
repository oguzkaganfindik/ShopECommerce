using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class FactManager : IFactService
    {
        private readonly IFactDal _factDal;

        public FactManager(IFactDal factDal)
        {
            _factDal = factDal;
        }

        public void TAdd(Fact entity)
        {
            _factDal.Add(entity);
        }

        public void TDelete(Fact entity)
        {
            _factDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _factDal.Delete(id);
        }

        public Fact TGet(Expression<Func<Fact, bool>> predicate)
        {
            return _factDal.Get(predicate);
        }

        public IQueryable<Fact> TGetAll(Expression<Func<Fact, bool>> predicate = null)
        {
            return _factDal.GetAll(predicate);
        }

        public Fact TGetById(int id)
        {
            return _factDal.GetById(id);
        }

        public List<Fact> TGetListAll()
        {
            return _factDal.GetListAll();
        }

        public IQueryable<Fact> TGetListByStatusTrue(Expression<Func<Fact, bool>> predicate = null)
        {
            return _factDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _factDal.ToggleStatus(id);
        }

        public void TUpdate(Fact entity)
        {
            _factDal.Update(entity);
        }
    }
}
