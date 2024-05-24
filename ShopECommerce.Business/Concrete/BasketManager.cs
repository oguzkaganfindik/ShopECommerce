using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class BasketManager : IBasketService
    {
        private readonly IBasketDal _basketDal;

        public BasketManager(IBasketDal basketDal)
        {
            _basketDal = basketDal;
        }

        public List<Basket> TGetListAll()
        {
            return _basketDal.GetListAll();
        }

        public void TAdd(Basket entity)
        {
            _basketDal.Add(entity);
        }

        public void TDelete(Basket entity)
        {
            _basketDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _basketDal.Delete(id);
        }

        public Basket TGet(Expression<Func<Basket, bool>> predicate)
        {
            return _basketDal.Get(predicate);
        }

        public IQueryable<Basket> TGetAll(Expression<Func<Basket, bool>> predicate = null)
        {
            return _basketDal.GetAll(predicate);
        }

        public async Task<List<Basket>> TGetBasketByBasketItemNumberAsync(int id)
        {
            return await _basketDal.GetBasketByBasketItemNumberAsync(id);
        }

        public async Task<List<ResultBasketListWithProductsDto>> TGetBasketListByBasketItemWithProductNameAsync(int id)
        {
            return await _basketDal.GetBasketListByBasketItemWithProductNameAsync(id);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }


        public async Task<decimal> TGetProductPriceAsync(int productId)
        {
            return await _basketDal.GetProductPriceAsync(productId);
        }

        public void TUpdate(Basket entity)
        {
            _basketDal.Update(entity);
        }

        public void TToggleStatus(int id)
        {
            _basketDal.ToggleStatus(id);
        }

        public IQueryable<Basket> TGetListByStatusTrue(Expression<Func<Basket, bool>> predicate = null)
        {
            return _basketDal.GetListByStatusTrue(predicate);
        }

        public void THardDelete(int id)
        {
            _basketDal.HardDelete(id);
        }

        public async Task TUpdateQuantityAsync(int basketId, int newQuantity) 
        {
            await _basketDal.UpdateQuantityAsync(basketId, newQuantity);
        }

        public async Task<int> TGetBasketItemCountAsync()
        {
            return await _basketDal.GetBasketItemCountAsync();
        }
    }
}
