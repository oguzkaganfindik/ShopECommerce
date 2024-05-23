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

        public void THardDelete(int id)
        {
            _discountDal.HardDelete(id);
        }

        public void TAdd(Discount entity)
        {
            _discountDal.Add(entity);
        }

        public async Task TChangeStatusToFalseAsync(int id)
        {
            await _discountDal.ChangeStatusToFalseAsync(id);
        }

        public async Task TChangeStatusToTrueAsync(int id)
        {
            await _discountDal.ChangeStatusToTrueAsync(id);
        }

        public void TDelete(Discount entity)
        {
            _discountDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _discountDal.Delete(id);
        }

        public Discount TGet(Expression<Func<Discount, bool>> predicate)
        {
            return _discountDal.Get(predicate);
        }

        public IQueryable<Discount> TGetAll(Expression<Func<Discount, bool>> predicate = null)
        {
            return _discountDal.GetAll(predicate);
        }

        public Discount TGetById(int id)
        {
            return _discountDal.GetById(id);
        }

        public List<Discount> TGetListAll()
        {
            return _discountDal.GetListAll();
        }

        public IQueryable<Discount> TGetListByStatusTrue(Expression<Func<Discount, bool>> predicate = null)
        {
            return _discountDal.GetListByStatusTrue(predicate);
        }

        public async Task<List<Discount>> TGetListByStatusTrueAsync()
        {
            return await _discountDal.GetListByStatusTrueAsync();
        }

        public void TToggleStatus(int id)
        {
            _discountDal.ToggleStatus(id);
        }

        public void TUpdate(Discount entity)
        {
            _discountDal.Update(entity);
        }
    }
}
