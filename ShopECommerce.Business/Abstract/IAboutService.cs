using ShopECommerce.DTOs.AboutDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IAboutService : IGenericService<About>
    {
        Task TUpdateAsync(UpdateAboutDto updateAboutDto);
        Task TAddAsync(CreateAboutDto createAboutDto);
    }
}
