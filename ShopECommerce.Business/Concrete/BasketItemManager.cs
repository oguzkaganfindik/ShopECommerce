using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class BasketItemManager : IBasketItemService
    {
        private readonly IBasketItemDal _basketItemDal;

        public BasketItemManager(IBasketItemDal basketItemDal)
        {
            _basketItemDal = basketItemDal;
        }

        public void THardDelete(int id)
        {
            _basketItemDal.HardDelete(id);
        }

        public void TAdd(BasketItem entity)
        {
            _basketItemDal.Add(entity);
        }

        public void TDelete(BasketItem entity)
        {
            _basketItemDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _basketItemDal.Delete(id);
        }

        public BasketItem TGet(Expression<Func<BasketItem, bool>> predicate)
        {
            return _basketItemDal.Get(predicate);
        }

        public IQueryable<BasketItem> TGetAll(Expression<Func<BasketItem, bool>> predicate = null)
        {
            return _basketItemDal.GetAll(predicate);
        }

        public BasketItem TGetById(int id)
        {
            return _basketItemDal.GetById(id);
        }

        public List<BasketItem> TGetListAll()
        {
            return _basketItemDal.GetListAll();
        }

        public IQueryable<BasketItem> TGetListByStatusTrue(Expression<Func<BasketItem, bool>> predicate = null)
        {
            return _basketItemDal.GetListByStatusTrue(predicate);
        }

        public async Task<int> TBasketItemCountAsync()
        {
            return await _basketItemDal.BasketItemCountAsync();
        }

        public void TToggleStatus(int id)
        {
            _basketItemDal.ToggleStatus(id);
        }

        public void TUpdate(BasketItem entity)
        {
            _basketItemDal.Update(entity);
        }
    }
}
