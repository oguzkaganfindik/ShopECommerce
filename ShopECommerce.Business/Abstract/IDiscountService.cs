using ShopECommerce.DTOs.DiscountDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IDiscountService : IGenericService<Discount>
    {
        Task TUpdateAsync(UpdateDiscountDto updateDiscountDto);
        Task TAddAsync(CreateDiscountDto createDiscountDto);
        Task TChangeStatusToTrueAsync(int id);
        Task TChangeStatusToFalseAsync(int id);
        Task<List<Discount>> TGetListByStatusTrueAsync();
    }
}
