using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Concrete;
using ShopECommerce.DTOs.BannerDto;
using ShopECommerce.DTOs.ContactDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;
using System.Numerics;

namespace ShopECommerce.Business.Concrete
{
    public class ContactManager : IContactService
    {
        private readonly IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public async Task<List<Contact>> GetListAllAsync()
        {
            return await _contactDal.GetListAllAsync();
        }

        public async Task THardDeleteAsync(int id)
        {
            await _contactDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Contact entity)
        {
            await _contactDal.AddAsync(entity);
        }

        public async Task TUpdateAsync(Contact entity)
        {
            await _contactDal.UpdateAsync(entity);
        }

        public async Task TDeleteAsync(Contact entity)
        {
            await _contactDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _contactDal.DeleteAsync(id);
        }

        public async Task<Contact> TGetAsync(Expression<Func<Contact, bool>> predicate)
        {
            return await _contactDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Contact>> TGetAllAsync(Expression<Func<Contact, bool>> predicate = null)
        {
            return await _contactDal.GetAllAsync(predicate);
        }

        public async Task<Contact> TGetByIdAsync(int id)
        {
            return await _contactDal.GetByIdAsync(id);
        }

        public async Task<List<Contact>> TGetListAllAsync()
        {
            return await _contactDal.GetListAllAsync();
        }

        public async Task<IQueryable<Contact>> TGetListByStatusTrueAsync(Expression<Func<Contact, bool>> predicate = null)
        {
            return await _contactDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _contactDal.ToggleStatusAsync(id);
        }

        public async Task TAddAsync(CreateContactDto createContactDto)
        {
            await _contactDal.AddAsync(new Contact()
            {
                Location = createContactDto.Location,
                Phone = createContactDto.Phone,
                Mail = createContactDto.Mail,
                FooterTitle = createContactDto.FooterTitle,
                FooterDescription = createContactDto.FooterDescription,
                SiteName = createContactDto.SiteName,
                SiteTitle = createContactDto.SiteTitle,
                SiteUrl = createContactDto.SiteUrl,
                GoogleMapsApi = createContactDto.GoogleMapsApi
            });
        }

        public async Task TUpdateAsync(UpdateContactDto updateContactDto)
        {
            var contact = await _contactDal.GetByIdAsync(updateContactDto.Id);
            if (contact == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            contact.Location = updateContactDto.Location;
            contact.Phone = updateContactDto.Phone;
            contact.Mail = updateContactDto.Mail;
            contact.FooterTitle = updateContactDto.FooterTitle;
            contact.FooterDescription = updateContactDto.FooterDescription;
            contact.SiteName = updateContactDto.SiteName;
            contact.SiteTitle = updateContactDto.SiteTitle;
            contact.SiteUrl = updateContactDto.SiteUrl;
            contact.GoogleMapsApi = updateContactDto.GoogleMapsApi;

            await _contactDal.UpdateAsync(contact);
        }    
    }
}
