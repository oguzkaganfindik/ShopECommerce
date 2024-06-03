using ShopECommerce.DTOs.SocialMediaDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface ISocialMediaService : IGenericService<SocialMedia>
    {
        Task TUpdateAsync(UpdateSocialMediaDto updateSocialMediaDto);
        Task TAddAsync(CreateSocialMediaDto createSocialMediaDto);
    }
}
