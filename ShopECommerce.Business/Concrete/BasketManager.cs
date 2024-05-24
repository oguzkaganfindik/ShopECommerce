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

        public List<Basket> TGetBasketByBasketItemNumber(int id)
        {
            return _basketDal.GetBasketByBasketItemNumber(id);
        }

        public List<ResultBasketListWithProductsDto> TGetBasketListByBasketItemWithProductName(int id)
        {
            return _basketDal.GetBasketListByBasketItemWithProductName(id);
        }

        public Basket TGetById(int id)
        {
            return _basketDal.GetById(id);
        }


        public decimal TGetProductPrice(int productId)
        {
            return _basketDal.GetProductPrice(productId);
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

        public void TUpdateQuantity(int basketId, int newQuantity) 
        {
            _basketDal.UpdateQuantity(basketId, newQuantity);
        }

        public async Task<int> TGetBasketItemCountAsync()
        {
            return await _basketDal.GetBasketItemCountAsync();
        }
    }
}
