using ShopECommerce.DTOs.ContactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IContactService : IGenericService<Contact>
    {
        Task TUpdateAsync(UpdateContactDto updateContactDto);
        Task TAddAsync(CreateContactDto createContactDto);
    }
}
