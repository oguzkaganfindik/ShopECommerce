using ShopECommerce.DTOs.FeaturDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IFeaturService : IGenericService<Featur>
    {
        Task TUpdateAsync(UpdateFeaturDto updateFeaturDto);
        Task TAddAsync(CreateFeaturDto createFeaturDto);
    }
}
