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

        public async Task THardDeleteAsync(int id)
        {
           await _bannerDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Banner entity)
        {
            await _bannerDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Banner entity)
        {
            await _bannerDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _bannerDal.DeleteAsync(id);
        }

        public async Task<Banner> TGetAsync(Expression<Func<Banner, bool>> predicate)
        {
            return await _bannerDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Banner>> TGetAllAsync(Expression<Func<Banner, bool>> predicate = null)
        {
            return await _bannerDal.GetAllAsync(predicate);
        }

        public async Task<Banner> TGetByIdAsync(int id)
        {
            return await _bannerDal.GetByIdAsync(id);
        }

        public async Task<List<Banner>> TGetListAllAsync()
        {
            return await _bannerDal.GetListAllAsync();
        }

        public async Task<IQueryable<Banner>> TGetListByStatusTrueAsync(Expression<Func<Banner, bool>> predicate = null)
        {
            return await _bannerDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _bannerDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(Banner entity)
        {
            await _bannerDal.UpdateAsync(entity);
        }
    }
}
