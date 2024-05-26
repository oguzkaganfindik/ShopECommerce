﻿using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class AboutManager : IAboutService
    {
        private readonly IAboutDal _aboutDal;

        public AboutManager(IAboutDal aboutDal)
        {
            _aboutDal = aboutDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _aboutDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(About entity)
        {
            await _aboutDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(About entity)
        {
            await _aboutDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _aboutDal.DeleteAsync(id);
        }

        public async Task<About> TGetAsync(Expression<Func<About, bool>> predicate)
        {
            return await _aboutDal.GetAsync(predicate);
        }

        public async Task<IQueryable<About>> TGetAllAsync(Expression<Func<About, bool>> predicate = null)
        {
            return await _aboutDal.GetAllAsync(predicate);
        }

        public async Task<About> TGetByIdAsync(int id)
        {
            return await _aboutDal.GetByIdAsync(id);
        }

        public async Task<List<About>> TGetListAllAsync()
        {
            return await _aboutDal.GetListAllAsync();
        }

        public async Task<IQueryable<About>> TGetListByStatusTrueAsync(Expression<Func<About, bool>> predicate = null)
        {
            return await _aboutDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _aboutDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(About entity)
        {
            await _aboutDal.UpdateAsync(entity);
        }
    }
}
