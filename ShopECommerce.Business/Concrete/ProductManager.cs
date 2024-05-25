using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public async Task<string> TProductNameByMaxPriceAsync()
        {
            return await _productDal.ProductNameByMaxPriceAsync();
        }

        public async Task<string> TProductNameByMinPriceAsync()
        {
            return await _productDal.ProductNameByMinPriceAsync();
        }

        public void TAdd(Product entity)
        {
            _productDal.Add(entity);
        }

        public void TDelete(Product entity)
        {
            _productDal.Delete(entity);
        }

        public Product TGetById(int id)
        {
            return _productDal.GetById(id);
        }


        public List<Product> TGetListAll()
        {
            return _productDal.GetListAll();
        }

        public async Task<int> TProductCountAsync()
        {
            return await _productDal.ProductCountAsync();
        }

        public async Task<int> TProductCountBySubCategoryNameTomatoAsync()
        {
            return await _productDal.ProductCountBySubCategoryNameTomatoAsync();
        }

        public async Task<int> TProductCountBySubCategoryNameAppleAsync()
        {
            return await _productDal.ProductCountBySubCategoryNameAppleAsync();
        }

        public async Task<decimal> TProductPriceAvgAsync()
        {
            return await _productDal.ProductPriceAvgAsync();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public async Task<decimal> TProductAvgPriceByAppleAsync()
        {
            return await _productDal.ProductAvgPriceByAppleAsync();
        }

        public async Task<decimal> TProductPriceByNativeOrangesAsync()
        {
            return await _productDal.ProductPriceByNativeOrangesAsync();
        }

        public async Task<decimal> TTotalPriceByTomatoSubCategoryAsync()
        {
            return await _productDal.TotalPriceByTomatoSubCategoryAsync();
        }

        public async Task<decimal> TTotalPriceByStrawberrySubCategoryAsync()
        {
            return await _productDal.TotalPriceByStrawberrySubCategoryAsync();
        }

        public async Task<List<ResultProductWithSubCategory>> TGetProductsWithSubCategoriesAsync()
        {
            return await _productDal.GetProductsWithSubCategoriesAsync();
        }

        public void TDelete(int id)
        {
            _productDal.Delete(id);
        }

        public Product TGet(Expression<Func<Product, bool>> predicate)
        {
            return _productDal.Get(predicate);
        }

        public IQueryable<Product> TGetAll(Expression<Func<Product, bool>> predicate = null)
        {
            return TGetAll(predicate);
        }

        public void TToggleStatus(int id)
        {
            _productDal.ToggleStatus(id);
        }

        public IQueryable<Product> TGetListByStatusTrue(Expression<Func<Product, bool>> predicate = null)
        {
            return _productDal.GetListByStatusTrue(predicate);
        }

        public async Task<List<ResultProductWithSubCategory>> TGetProductListByVegetableAsync()
        {
            return await _productDal.GetProductListByVegetableAsync();
        }      

        public async Task<List<ResultProductWithSubCategory>> TGetProductListByFruitesAsync()
        {
            return await _productDal.GetProductListByFruitesAsync();
        }

        public async Task<GetProductShowcaseDetailDto> TGetProductShowcaseDetailIdAsync(int id)
        {
            return await _productDal.GetProductShowcaseDetailIdAsync(id);
        }

        public void THardDelete(int id)
        {
            _productDal.HardDelete(id);
        }
    }
}
