using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Concrete;
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

        public int TActiveSubCategoryCount()
        {
            return _subCategoryDal.ActiveSubCategoryCount();
        }

        public void TAdd(SubCategory entity)
        {
            _subCategoryDal.Add(entity);
        }

        public int TSubCategoryCount()
        {
            return _subCategoryDal.SubCategoryCount();
        }

        public void TDelete(SubCategory entity)
        {
            _subCategoryDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _subCategoryDal.Delete(id);
        }

        public SubCategory TGet(Expression<Func<SubCategory, bool>> predicate)
        {
            return _subCategoryDal.Get(predicate);
        }

        public IQueryable<SubCategory> TGetAll(Expression<Func<SubCategory, bool>> predicate = null)
        {
            return _subCategoryDal.GetAll(predicate);
        }

        public SubCategory TGetById(int id)
        {
            return _subCategoryDal.GetById(id);
        }

        public List<SubCategory> TGetListAll()
        {
            return _subCategoryDal.GetListAll();
        }

        public IQueryable<SubCategory> TGetListByStatusTrue(Expression<Func<SubCategory, bool>> predicate = null)
        {
            return _subCategoryDal.GetListByStatusTrue(predicate);
        }

        public int TPassiveSubCategoryCount()
        {
            return _subCategoryDal.PassiveSubCategoryCount();
        }

        public void TToggleStatus(int id)
        {
            _subCategoryDal.ToggleStatus(id);
        }

        public void TUpdate(SubCategory entity)
        {
            _subCategoryDal.Update(entity);
        }

        public List<ResultSubCategoryWithCategory> TGetSubCategoriesWithCategories()
        {
            return _subCategoryDal.GetSubCategoriesWithCategories();
        }

        public void THardDelete(int id)
        {
            _subCategoryDal.HardDelete(id);
        }
    }
}
