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

        public async Task<List<Basket>> TGetListAllAsync()
        {
            return await _basketDal.GetListAllAsync();
        }

        public async Task TAddAsync(Basket entity)
        {
            await _basketDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Basket entity)
        {
            await _basketDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _basketDal.DeleteAsync(id);
        }

        public async Task<Basket> TGetAsync(Expression<Func<Basket, bool>> predicate)
        {
            return await _basketDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Basket>> TGetAllAsync(Expression<Func<Basket, bool>> predicate = null)
        {
            return await _basketDal.GetAllAsync(predicate);
        }

        public async Task<List<Basket>> TGetBasketByBasketItemNumberAsync(int id)
        {
            return await _basketDal.GetBasketByBasketItemNumberAsync(id);
        }

        public async Task<List<ResultBasketListWithProductsDto>> TGetBasketListByBasketItemWithProductNameAsync(int id)
        {
            return await _basketDal.GetBasketListByBasketItemWithProductNameAsync(id);
        }

        public async Task<Basket> TGetByIdAsync(int id)
        {
            return await _basketDal.GetByIdAsync(id);
        }


        public async Task<decimal> TGetProductPriceAsync(int productId)
        {
            return await _basketDal.GetProductPriceAsync(productId);
        }

        public async Task TUpdateAsync(Basket entity)
        {
            await _basketDal.UpdateAsync(entity);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _basketDal.ToggleStatusAsync(id);
        }

        public async Task<IQueryable<Basket>> TGetListByStatusTrueAsync(Expression<Func<Basket, bool>> predicate = null)
        {
            return await _basketDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task THardDeleteAsync(int id)
        {
            await _basketDal.HardDeleteAsync(id);
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
