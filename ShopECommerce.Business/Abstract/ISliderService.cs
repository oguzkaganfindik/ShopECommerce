using ShopECommerce.DTOs.SliderDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ISliderService : IGenericService<Slider>
    {
        Task TUpdateAsync(UpdateSliderDto updateSliderDto);
        Task TAddAsync(CreateSliderDto createSliderDto);
    }
}
