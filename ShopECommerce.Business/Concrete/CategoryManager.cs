using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.CategoryDto;
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

        public async Task THardDeleteAsync(int id)
        {
            await _categoryDal.HardDeleteAsync(id);
        }

        public async Task<int> TActiveCategoryCountAsync()
        {
            return await _categoryDal.ActiveCategoryCountAsync();
        }

        public async Task TAddAsync(Category entity)
        {
            await _categoryDal.AddAsync(entity);
        }

        public async Task TUpdateAsync(Category entity)
        {
            await _categoryDal.UpdateAsync(entity);
        }

        public async Task<int> TCategoryCountAsync()
        {
            return await _categoryDal.CategoryCountAsync();
        }

        public async Task TDeleteAsync(Category entity)
        {
            await _categoryDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _categoryDal.DeleteAsync(id);
        }

        public async Task<Category> TGetAsync(Expression<Func<Category, bool>> predicate)
        {
            return await _categoryDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Category>> TGetAllAsync(Expression<Func<Category, bool>> predicate = null)
        {
            return await _categoryDal.GetAllAsync(predicate);
        }

        public async Task<Category> TGetByIdAsync(int id)
        {
            return await _categoryDal.GetByIdAsync(id);
        }

        public async Task<List<Category>> TGetListAllAsync()
        {
            return await _categoryDal.GetListAllAsync();
        }

        public async Task<IQueryable<Category>> TGetListByStatusTrueAsync(Expression<Func<Category, bool>> predicate = null)
        {
            return await _categoryDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<int> TPassiveCategoryCountAsync()
        {
            return await _categoryDal.PassiveCategoryCountAsync();
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _categoryDal.ToggleStatusAsync(id);
        }

        public async Task TUpdateAsync(UpdateCategoryDto updateCategoryDto)
        {
            var category = await _categoryDal.GetByIdAsync(updateCategoryDto.Id);
            if (category == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            category.CategoryName = updateCategoryDto.CategoryName;

            await _categoryDal.UpdateAsync(category);
        }

        public async Task TAddAsync(CreateCategoryDto createCategoryDto)
        {
            await _categoryDal.AddAsync(new Category()
            {
                CategoryName = createCategoryDto.CategoryName
            });
        }
    }
}
