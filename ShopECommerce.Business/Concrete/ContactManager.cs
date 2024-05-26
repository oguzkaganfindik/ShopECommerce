using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

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

        public async Task TUpdateAsync(Contact entity)
        {
            await _contactDal.UpdateAsync(entity);
        }
    }
}
