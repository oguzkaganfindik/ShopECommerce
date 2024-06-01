using ShopECommerce.DTOs.FactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IFactService : IGenericService<Fact>
    {
        Task TUpdateAsync(UpdateFactDto updateFactDto);
        Task TAddAsync(CreateFactDto createFactDto);
    }
}
