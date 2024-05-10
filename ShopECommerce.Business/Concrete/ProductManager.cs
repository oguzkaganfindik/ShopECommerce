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

        public string TProductNameByMaxPrice()
        {
            return _productDal.ProductNameByMaxPrice();
        }

        public string TProductNameByMinPrice()
        {
            return _productDal.ProductNameByMinPrice();
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

        public int TProductCount()
        {
            return _productDal.ProductCount();
        }

        public int TProductCountBySubCategoryNameDrink()
        {
            return _productDal.ProductCountBySubCategoryNameDrink();
        }

        public int TProductCountBySubCategoryNameHamburger()
        {
            return _productDal.ProductCountBySubCategoryNameHamburger();
        }

        public decimal TProductPriceAvg()
        {
            return _productDal.ProductPriceAvg();
        }

        public void TUpdate(Product entity)
        {
            _productDal.Update(entity);
        }

        public decimal TProductAvgPriceByHamburger()
        {
            return _productDal.ProductAvgPriceByHamburger();
        }

        public decimal TProductPriceBySteakBurger()
        {
            return _productDal.ProductPriceBySteakBurger();
        }

        public decimal TTotalPriceByDrinkSubCategory()
        {
            return _productDal.TotalPriceByDrinkSubCategory();
        }

        public decimal TTotalPriceBySaladSubCategory()
        {
            return _productDal.TotalPriceBySaladSubCategory();
        }

        public List<ResultProductWithSubCategory> TGetProductsWithSubCategories()
        {
            return _productDal.GetProductsWithSubCategories();
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

        public List<ResultProductWithCategory> TGetProductListByVegetable()
        {
            return _productDal.GetProductListByVegetable();
        }      

        public List<ResultProductWithCategory> TGetProductListByFruites()
        {
            return _productDal.GetProductListByFruites();
        }

        public GetProductShowcaseDetailDto TGetProductShowcaseDetailId(int id)
        {
            return _productDal.GetProductShowcaseDetailId(id);
        }

        //public void THardDelete(Product entity)
        //{
        //    _productDal.HardDelete(entity);
        //}

        public void THardDelete(int id)
        {
            _productDal.HardDelete(id);
        }
    }
}
