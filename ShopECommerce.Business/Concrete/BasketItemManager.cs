using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.BasketItemDto;
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

        public async Task THardDeleteAsync(int id)
        {
            await _basketItemDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(BasketItem entity)
        {
            await _basketItemDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(BasketItem entity)
        {
            await _basketItemDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(BasketItem entity)
        {
            await _basketItemDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _basketItemDal.DeleteAsync(id);
        }

        public async Task<BasketItem> TGetAsync(Expression<Func<BasketItem, bool>> predicate)
        {
            return await _basketItemDal.GetAsync(predicate);
        }

        public async Task<IQueryable<BasketItem>> TGetAllAsync(Expression<Func<BasketItem, bool>> predicate = null)
        {
            return await _basketItemDal.GetAllAsync(predicate);
        }

        public async Task<BasketItem> TGetByIdAsync(int id)
        {
            return await _basketItemDal.GetByIdAsync(id);
        }

        public async Task<List<BasketItem>> TGetListAllAsync()
        {
            return await _basketItemDal.GetListAllAsync();
        }

        public async Task<IQueryable<BasketItem>> TGetListByStatusTrueAsync(Expression<Func<BasketItem, bool>> predicate = null)
        {
            return await _basketItemDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<int> TBasketItemCountAsync()
        {
            return await _basketItemDal.BasketItemCountAsync();
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _basketItemDal.ToggleStatusAsync(id);
        }
  
        public async Task TUpdateAsync(UpdateBasketItemDto updateBasketItemDto)
        {
            var basketItem = await _basketItemDal.GetByIdAsync(updateBasketItemDto.Id);
            if (basketItem == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            basketItem.BasketItemCustomerMail = updateBasketItemDto.BasketItemCustomerMail;
            basketItem.Status = updateBasketItemDto.Status;

            await _basketItemDal.UpdateAsync(basketItem);
        }

        public async Task TAddAsync(CreateBasketItemDto createBasketItemDto)
        {
            await _basketItemDal.AddAsync(new BasketItem()
            {
                BasketItemCustomerMail = createBasketItemDto.BasketItemCustomerMail,
                Status = createBasketItemDto.Status
            });
        }
    }
}