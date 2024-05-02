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

        public void TAdd(Slider entity)
        {
            _sliderDal.Add(entity);
        }

        public void TDelete(Slider entity)
        {
            _sliderDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _sliderDal.Delete(id);
        }

        public Slider TGet(Expression<Func<Slider, bool>> predicate)
        {
            return _sliderDal.Get(predicate);
        }

        public IQueryable<Slider> TGetAll(Expression<Func<Slider, bool>> predicate = null)
        {
            return _sliderDal.GetAll(predicate);
        }

        public Slider TGetById(int id)
        {
            return _sliderDal.GetById(id);
        }

        public List<Slider> TGetListAll()
        {
            return _sliderDal.GetListAll();
        }

        public IQueryable<Slider> TGetListByStatusTrue(Expression<Func<Slider, bool>> predicate = null)
        {
            return _sliderDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _sliderDal.ToggleStatus(id);
        }

        public void TUpdate(Slider entity)
        {
            _sliderDal.Update(entity);
        }
    }
}
