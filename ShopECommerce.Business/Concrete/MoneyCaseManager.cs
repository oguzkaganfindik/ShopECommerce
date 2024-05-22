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

        public void THardDelete(int id)
        {
            _moneyCaseDal.HardDelete(id);
        }

        public void TAdd(MoneyCase entity)
        {
            _moneyCaseDal.Add(entity);
        }

        public void TDelete(MoneyCase entity)
        {
            _moneyCaseDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _moneyCaseDal.Delete(id);
        }

        public MoneyCase TGet(Expression<Func<MoneyCase, bool>> predicate)
        {
            return _moneyCaseDal.Get(predicate);
        }

        public IQueryable<MoneyCase> TGetAll(Expression<Func<MoneyCase, bool>> predicate = null)
        {
            return _moneyCaseDal.GetAll(predicate);
        }

        public MoneyCase TGetById(int id)
        {
            return _moneyCaseDal.GetById(id);
        }

        public List<MoneyCase> TGetListAll()
        {
            return _moneyCaseDal.GetListAll();
        }

        public IQueryable<MoneyCase> TGetListByStatusTrue(Expression<Func<MoneyCase, bool>> predicate = null)
        {
            return _moneyCaseDal.GetListByStatusTrue(predicate);
        }

        public void TToggleStatus(int id)
        {
            _moneyCaseDal.ToggleStatus(id);
        }

        public async Task<decimal> TTotalMoneyCaseAmountAsync()
        {
            return await _moneyCaseDal.TotalMoneyCaseAmountAsync();
        }

        public void TUpdate(MoneyCase entity)
        {
            _moneyCaseDal.Update(entity);
        }
    }
}
