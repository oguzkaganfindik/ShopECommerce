using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        private readonly ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal SubCategoryDal)
        {
            _subCategoryDal = SubCategoryDal;
        }

        public async Task<int> TActiveSubCategoryCountAsync()
        {
            return await _subCategoryDal.ActiveSubCategoryCountAsync();
        }

        public async Task TAddAsync(SubCategory entity)
        {
            await _subCategoryDal.AddAsync(entity);
        }

        public async Task<int> TSubCategoryCountAsync()
        {
            return await _subCategoryDal.SubCategoryCountAsync();
        }

        public async Task TDeleteAsync(SubCategory entity)
        {
            await _subCategoryDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _subCategoryDal.DeleteAsync(id);
        }

        public async Task<SubCategory> TGetAsync(Expression<Func<SubCategory, bool>> predicate)
        {
            return await _subCategoryDal.GetAsync(predicate);
        }

        public async Task<IQueryable<SubCategory>> TGetAllAsync(Expression<Func<SubCategory, bool>> predicate = null)
        {
            return await _subCategoryDal.GetAllAsync(predicate);
        }

        public async Task<SubCategory> TGetByIdAsync(int id)
        {
            return await _subCategoryDal.GetByIdAsync(id);
        }

        public async Task<List<SubCategory>> TGetListAllAsync()
        {
            return await _subCategoryDal.GetListAllAsync();
        }

        public async Task<IQueryable<SubCategory>> TGetListByStatusTrueAsync(Expression<Func<SubCategory, bool>> predicate = null)
        {
            return await _subCategoryDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<int> TPassiveSubCategoryCountAsync()
        {
            return await _subCategoryDal.PassiveSubCategoryCountAsync();
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _subCategoryDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(SubCategory entity)
        {
            await _subCategoryDal.UpdateAsync(entity);
        }

        public async Task<List<ResultSubCategoryWithCategory>> TGetSubCategoriesWithCategoriesAsync()
        {
            return await _subCategoryDal.GetSubCategoriesWithCategoriesAsync();
        }

        public async Task THardDeleteAsync(int id)
        {
            await _subCategoryDal.HardDeleteAsync(id);
        }
    }
}
