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

        public List<Contact> GetListAll()
        {
            return _contactDal.GetListAll();
        }

        public void THardDelete(int id)
        {
            _contactDal.HardDelete(id);
        }

        public void TAdd(Contact entity)
        {
            _contactDal.Add(entity);
        }

        public void TDelete(Contact entity)
        {
            _contactDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _contactDal.Delete(id);
        }

        public Contact TGet(Expression<Func<Contact, bool>> predicate)
        {
            return _contactDal.Get(predicate);
        }

        public IQueryable<Contact> TGetAll(Expression<Func<Contact, bool>> predicate = null)
        {
            return _contactDal.GetAll(predicate);
        }

        public Contact TGetById(int id)
        {
            return _contactDal.GetById(id);
        }

        public List<Contact> TGetListAll()
        {
            return _contactDal.GetListAll();
        }

        public IQueryable<Contact> TGetListByStatusTrue(Expression<Func<Contact, bool>> predicate = null)
        {
            return _contactDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _contactDal.ToggleStatus(id);
        }

        public void TUpdate(Contact entity)
        {
            _contactDal.Update(entity);
        }
    }
}
