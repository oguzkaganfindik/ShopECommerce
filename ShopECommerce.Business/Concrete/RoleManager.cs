using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public void THardDelete(int id)
        {
            _roleDal.HardDelete(id);
        }

        public void TAdd(Role entity)
        {
            _roleDal.Add(entity);
        }

        public void TDelete(Role entity)
        {
            _roleDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _roleDal.Delete(id);
        }

        public Role TGet(Expression<Func<Role, bool>> predicate)
        {
            return _roleDal.Get(predicate);
        }

        public IQueryable<Role> TGetAll(Expression<Func<Role, bool>> predicate = null)
        {
            return _roleDal.GetAll(predicate);
        }

        public Role TGetById(int id)
        {
            return _roleDal.GetById(id);
        }

        public List<Role> TGetListAll()
        {
            return _roleDal.GetListAll();
        }

        public IQueryable<Role> TGetListByStatusTrue(Expression<Func<Role, bool>> predicate = null)
        {
            return _roleDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _roleDal.ToggleStatus(id);
        }

        public void TUpdate(Role entity)
        {
            _roleDal.Update(entity);
        }
    }
}
