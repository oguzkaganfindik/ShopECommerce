using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class MenuTableManager : IMenuTableService
    {
        private readonly IMenuTableDal _menuTableDal;

        public MenuTableManager(IMenuTableDal menuTableDal)
        {
            _menuTableDal = menuTableDal;
        }

        public void TAdd(MenuTable entity)
        {
            _menuTableDal.Add(entity);
        }

        public void TDelete(MenuTable entity)
        {
            _menuTableDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _menuTableDal.Delete(id);
        }

        public MenuTable TGet(Expression<Func<MenuTable, bool>> predicate)
        {
            return _menuTableDal.Get(predicate);
        }

        public IQueryable<MenuTable> TGetAll(Expression<Func<MenuTable, bool>> predicate = null)
        {
            return _menuTableDal.GetAll(predicate);
        }

        public MenuTable TGetById(int id)
        {
            return _menuTableDal.GetById(id);
        }

        public List<MenuTable> TGetListAll()
        {
            return _menuTableDal.GetListAll();
        }

        public IQueryable<MenuTable> TGetListByStatusTrue(Expression<Func<MenuTable, bool>> predicate = null)
        {
            return _menuTableDal.GetListByStatusTrue(predicate);
        }

        public int TMenuTableCount()
        {
            return _menuTableDal.MenuTableCount();
        }

        public void TToggleStatus(int id)
        {
            _menuTableDal.ToggleStatus(id);
        }

        public void TUpdate(MenuTable entity)
        {
            _menuTableDal.Update(entity);
        }
    }
}
