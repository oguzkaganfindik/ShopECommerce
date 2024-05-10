using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class SocialMediaManager : ISocialMediaService
    {
        private readonly ISocialMediaDal _socialMediaDal;

        public SocialMediaManager(ISocialMediaDal socialMediaDal)
        {
            _socialMediaDal = socialMediaDal;
        }
        public void THardDelete(int id)
        {
            _socialMediaDal.HardDelete(id);
        }

        public void TAdd(SocialMedia entity)
        {
            _socialMediaDal.Add(entity);
        }

        public void TDelete(SocialMedia entity)
        {
            _socialMediaDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _socialMediaDal.Delete(id);
        }

        public SocialMedia TGet(Expression<Func<SocialMedia, bool>> predicate)
        {
            return _socialMediaDal.Get(predicate);
        }

        public IQueryable<SocialMedia> TGetAll(Expression<Func<SocialMedia, bool>> predicate = null)
        {
            return _socialMediaDal.GetAll(predicate);
        }

        public SocialMedia TGetById(int id)
        {
            return _socialMediaDal.GetById(id);
        }

        public List<SocialMedia> TGetListAll()
        {
            return _socialMediaDal.GetListAll();
        }

        public IQueryable<SocialMedia> TGetListByStatusTrue(Expression<Func<SocialMedia, bool>> predicate = null)
        {
            return _socialMediaDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _socialMediaDal.ToggleStatus(id);
        }

        public void TUpdate(SocialMedia entity)
        {
            _socialMediaDal.Update(entity);
        }
    }
}
