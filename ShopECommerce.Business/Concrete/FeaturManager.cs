using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class FeaturManager : IFeaturService
    {
        private readonly IFeaturDal _featurDal;

        public FeaturManager(IFeaturDal featurDal)
        {
            _featurDal = featurDal;
        }

        public void TAdd(Featur entity)
        {
            _featurDal.Add(entity);
        }

        public void TDelete(Featur entity)
        {
            _featurDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _featurDal.Delete(id);
        }

        public Featur TGet(Expression<Func<Featur, bool>> predicate)
        {
            return _featurDal.Get(predicate);
        }

        public IQueryable<Featur> TGetAll(Expression<Func<Featur, bool>> predicate = null)
        {
            return _featurDal.GetAll(predicate);
        }

        public Featur TGetById(int id)
        {
            return _featurDal.GetById(id);
        }

        public List<Featur> TGetListAll()
        {
            return _featurDal.GetListAll();
        }

        public IQueryable<Featur> TGetListByStatusTrue(Expression<Func<Featur, bool>> predicate = null)
        {
            return _featurDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _featurDal.ToggleStatus(id);
        }

        public void TUpdate(Featur entity)
        {
            _featurDal.Update(entity);
        }
    }
}
