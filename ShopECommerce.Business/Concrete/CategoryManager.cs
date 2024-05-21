using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void THardDelete(int id)
        {
            _categoryDal.HardDelete(id);
        }

        public async Task<int> TActiveCategoryCountAsync()
        {
            return await _categoryDal.ActiveCategoryCountAsync();
        }

        public void TAdd(Category entity)
        {
            _categoryDal.Add(entity);
        }

        public async Task<int> TCategoryCountAsync()
        {
            return await _categoryDal.CategoryCountAsync();
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _categoryDal.Delete(id);
        }

        public Category TGet(Expression<Func<Category, bool>> predicate)
        {
            return _categoryDal.Get(predicate);
        }

        public IQueryable<Category> TGetAll(Expression<Func<Category, bool>> predicate = null)
        {
            return _categoryDal.GetAll(predicate);
        }

        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
        }

        public List<Category> TGetListAll()
        {
            return _categoryDal.GetListAll();
        }

        public IQueryable<Category> TGetListByStatusTrue(Expression<Func<Category, bool>> predicate = null)
        {
            return _categoryDal.GetListByStatusTrue(predicate);
        }

        public async Task<int> TPassiveCategoryCountAsync()
        {
            return await _categoryDal.PassiveCategoryCountAsync();
        }

        public void TToggleStatus(int id)
        {
            _categoryDal.ToggleStatus(id);
        }

        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
        }
    }
}
