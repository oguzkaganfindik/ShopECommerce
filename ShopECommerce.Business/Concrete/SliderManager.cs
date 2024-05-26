using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class SliderManager : ISliderService
    {
        private readonly ISliderDal _sliderDal;

        public SliderManager(ISliderDal sliderDal)
        {
            _sliderDal = sliderDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _sliderDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Slider entity)
        {
            await _sliderDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Slider entity)
        {
            await _sliderDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _sliderDal.DeleteAsync(id);
        }

        public async Task<Slider> TGetAsync(Expression<Func<Slider, bool>> predicate)
        {
            return await _sliderDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Slider>> TGetAllAsync(Expression<Func<Slider, bool>> predicate = null)
        {
            return await _sliderDal.GetAllAsync(predicate);
        }

        public async Task<Slider> TGetByIdAsync(int id)
        {
            return await _sliderDal.GetByIdAsync(id);
        }

        public async Task<List<Slider>> TGetListAllAsync()
        {
            return await _sliderDal.GetListAllAsync();
        }

        public async Task<IQueryable<Slider>> TGetListByStatusTrueAsync(Expression<Func<Slider, bool>> predicate = null)
        {
            return await _sliderDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _sliderDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(Slider entity)
        {
            await _sliderDal.UpdateAsync(entity);
        }
    }
}
