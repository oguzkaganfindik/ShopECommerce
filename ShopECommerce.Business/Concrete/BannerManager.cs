using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class BannerManager : IBannerService
    {
        private readonly IBannerDal _bannerDal;

        public BannerManager(IBannerDal bannerDal)
        {
            _bannerDal = bannerDal;
        }

        public void THardDelete(int id)
        {
            _bannerDal.HardDelete(id);
        }

        public void TAdd(Banner entity)
        {
            _bannerDal.Add(entity);
        }

        public void TDelete(Banner entity)
        {
            _bannerDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _bannerDal.Delete(id);
        }

        public Banner TGet(Expression<Func<Banner, bool>> predicate)
        {
            return _bannerDal.Get(predicate);
        }

        public IQueryable<Banner> TGetAll(Expression<Func<Banner, bool>> predicate = null)
        {
            return _bannerDal.GetAll(predicate);
        }

        public Banner TGetById(int id)
        {
            return _bannerDal.GetById(id);
        }

        public List<Banner> TGetListAll()
        {
            return _bannerDal.GetListAll();
        }

        public IQueryable<Banner> TGetListByStatusTrue(Expression<Func<Banner, bool>> predicate = null)
        {
            return _bannerDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _bannerDal.ToggleStatus(id);
        }

        public void TUpdate(Banner entity)
        {
            _bannerDal.Update(entity);
        }
    }
}
