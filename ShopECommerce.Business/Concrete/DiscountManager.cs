﻿using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class DiscountManager : IDiscountService
    {
        private readonly IDiscountDal _discountDal;

        public DiscountManager(IDiscountDal discountDal)
        {
            _discountDal = discountDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _discountDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Discount entity)
        {
            await _discountDal.AddAsync(entity);
        }

        public async Task TChangeStatusToFalseAsync(int id)
        {
            await _discountDal.ChangeStatusToFalseAsync(id);
        }

        public async Task TChangeStatusToTrueAsync(int id)
        {
            await _discountDal.ChangeStatusToTrueAsync(id);
        }

        public async Task TDeleteAsync(Discount entity)
        {
            await _discountDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _discountDal.DeleteAsync(id);
        }

        public async Task<Discount> TGetAsync(Expression<Func<Discount, bool>> predicate)
        {
            return await _discountDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Discount>> TGetAllAsync(Expression<Func<Discount, bool>> predicate = null)
        {
            return await _discountDal.GetAllAsync(predicate);
        }

        public async Task<Discount> TGetByIdAsync(int id)
        {
            return await _discountDal.GetByIdAsync(id);
        }

        public async Task<List<Discount>> TGetListAllAsync()
        {
            return await _discountDal.GetListAllAsync();
        }

        public async Task<IQueryable<Discount>> TGetListByStatusTrueAsync(Expression<Func<Discount, bool>> predicate = null)
        {
            return await _discountDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<List<Discount>> TGetListByStatusTrueAsync()
        {
            return await _discountDal.GetListByStatusTrueAsync();
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _discountDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(Discount entity)
        {
            await _discountDal.UpdateAsync(entity);
        }
    }
}
