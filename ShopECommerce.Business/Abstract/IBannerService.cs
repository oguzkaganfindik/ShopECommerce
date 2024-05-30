using ShopECommerce.DTOs.BannerDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IBannerService : IGenericService<Banner>
    {
        Task TUpdateAsync(UpdateBannerDto updateBannerDto);
        Task TAddAsync(CreateBannerDto createBannerDto);
    }
}
