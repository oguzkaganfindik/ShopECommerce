using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class MoneyCaseManager : IMoneyCaseService
    {
        private readonly IMoneyCaseDal _moneyCaseDal;

        public MoneyCaseManager(IMoneyCaseDal moneyCaseDal)
        {
            _moneyCaseDal = moneyCaseDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _moneyCaseDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(MoneyCase entity)
        {
            await _moneyCaseDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(MoneyCase entity)
        {
            await _moneyCaseDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _moneyCaseDal.DeleteAsync(id);
        }

        public async Task<MoneyCase> TGetAsync(Expression<Func<MoneyCase, bool>> predicate)
        {
            return await _moneyCaseDal.GetAsync(predicate);
        }

        public async Task<IQueryable<MoneyCase>> TGetAllAsync(Expression<Func<MoneyCase, bool>> predicate = null)
        {
            return await _moneyCaseDal.GetAllAsync(predicate);
        }

        public async Task<MoneyCase> TGetByIdAsync(int id)
        {
            return await _moneyCaseDal.GetByIdAsync(id);
        }

        public async Task<List<MoneyCase>> TGetListAllAsync()
        {
            return await _moneyCaseDal.GetListAllAsync();
        }

        public async Task<IQueryable<MoneyCase>> TGetListByStatusTrueAsync(Expression<Func<MoneyCase, bool>> predicate = null)
        {
            return await _moneyCaseDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _moneyCaseDal.ToggleStatusAsync(id);
        }

        public async Task<decimal> TTotalMoneyCaseAmountAsync()
        {
            return await _moneyCaseDal.TotalMoneyCaseAmountAsync();
        }

        public async Task TUpdateAsync(MoneyCase entity)
        {
            await _moneyCaseDal.UpdateAsync(entity);
        }
    }
}
