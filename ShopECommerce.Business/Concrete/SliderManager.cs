using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.SliderDto;
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
        public async Task TUpdateAsync(Slider entity)
        {
            await _sliderDal.UpdateAsync(entity);
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

        public async Task TUpdateAsync(UpdateSliderDto updateSliderDto)
        {
            var slider = await _sliderDal.GetByIdAsync(updateSliderDto.Id);
            if (slider == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            slider.Title = updateSliderDto.Title;
            slider.Description = updateSliderDto.Description;
            slider.Label1 = updateSliderDto.Label1;
            slider.ImagePath1 = updateSliderDto.ImagePath1;
            slider.Url1 = updateSliderDto.Url1;
            slider.Label2 = updateSliderDto.Label2;
            slider.ImagePath2 = updateSliderDto.ImagePath2;
            slider.Url2 = updateSliderDto.Url2;
            slider.Status = updateSliderDto.Status;

            await _sliderDal.UpdateAsync(slider);
        }

        public async Task TAddAsync(CreateSliderDto createSliderDto)
        {
            await _sliderDal.AddAsync(new Slider()
            {
                Title = createSliderDto.Title,
                Description = createSliderDto.Description,
                Label1 = createSliderDto.Label1,
                ImagePath1 = createSliderDto.ImagePath1,
                Url1 = createSliderDto.Url1,
                Label2 = createSliderDto.Label2,
                ImagePath2 = createSliderDto.ImagePath2,
                Url2 = createSliderDto.Url2,
                Status = createSliderDto.Status
            });
        }
    }
}
