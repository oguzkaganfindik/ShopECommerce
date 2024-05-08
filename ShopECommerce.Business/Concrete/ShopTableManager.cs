using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class ShopTableManager : IShopTableService
    {
        private readonly IShopTableDal _shopTableDal;

        public ShopTableManager(IShopTableDal shopTableDal)
        {
            _shopTableDal = shopTableDal;
        }

        public void TAdd(ShopTable entity)
        {
            _shopTableDal.Add(entity);
        }

        public void TDelete(ShopTable entity)
        {
            _shopTableDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _shopTableDal.Delete(id);
        }

        public ShopTable TGet(Expression<Func<ShopTable, bool>> predicate)
        {
            return _shopTableDal.Get(predicate);
        }

        public IQueryable<ShopTable> TGetAll(Expression<Func<ShopTable, bool>> predicate = null)
        {
            return _shopTableDal.GetAll(predicate);
        }

        public ShopTable TGetById(int id)
        {
            return _shopTableDal.GetById(id);
        }

        public List<ShopTable> TGetListAll()
        {
            return _shopTableDal.GetListAll();
        }

        public IQueryable<ShopTable> TGetListByStatusTrue(Expression<Func<ShopTable, bool>> predicate = null)
        {
            return _shopTableDal.GetListByStatusTrue(predicate);
        }

        public int TShopTableCount()
        {
            return _shopTableDal.ShopTableCount();
        }

        public void TToggleStatus(int id)
        {
            _shopTableDal.ToggleStatus(id);
        }

        public void TUpdate(ShopTable entity)
        {
            _shopTableDal.Update(entity);
        }
    }
}
