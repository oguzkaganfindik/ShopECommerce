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

        public async Task TAddAsync(Product entity)
        {
            await _productDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(Product entity)
        {
            await _productDal.DeleteAsync(entity);
        }

        public async Task<Product> TGetByIdAsync(int id)
        {
            return await _productDal.GetByIdAsync(id);
        }


        public async Task<List<Product>> TGetListAllAsync()
        {
            return await _productDal.GetListAllAsync();
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

        public async Task TUpdateAsync(Product entity)
        {
            await _productDal.UpdateAsync(entity);
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

        public async Task TDeleteAsync(int id)
        {
            await _productDal.DeleteAsync(id);
        }

        public async Task<Product> TGetAsync(Expression<Func<Product, bool>> predicate)
        {
            return await _productDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Product>> TGetAllAsync(Expression<Func<Product, bool>> predicate = null)
        {
            return await TGetAllAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _productDal.ToggleStatusAsync(id);
        }

        public async Task<IQueryable<Product>> TGetListByStatusTrueAsync(Expression<Func<Product, bool>> predicate = null)
        {
            return await _productDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<List<ResultProductWithSubCategory>> TGetProductListByVegetableAsync()
        {
            return await _productDal.GetProductListByVegetableAsync();
        }

        public async Task<List<ResultProductWithSubCategory>> TGetProductListByFruitesAsync()
        {
            return await _productDal.GetProductListByFruitesAsync();
        }

        public async Task<GetProductShowcaseDetailDto> TGetProductShowcaseDetailAsync(int id)
        {
            return await _productDal.GetProductShowcaseDetailAsync(id);
        }

        public async Task THardDeleteAsync(int id)
        {
            await _productDal.HardDeleteAsync(id);
        }
        public async Task TUpdateAsync(UpdateProductDto updateProductDto)
        {
            var product = await _productDal.GetByIdAsync(updateProductDto.Id);
            if (product == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            product.ProductName = updateProductDto.ProductName;
            product.Description = updateProductDto.Description;
            product.Price = updateProductDto.Price;
            product.ImagePath = updateProductDto.ImagePath;
            product.SubCategoryId = updateProductDto.SubCategoryId;
            product.ProductTitle = updateProductDto.ProductTitle;
            product.Weight = updateProductDto.Weight;
            product.CountryOfOrigin = updateProductDto.CountryOfOrigin;
            product.Quality = updateProductDto.Quality;
            product.Сheck = updateProductDto.Сheck;
            product.MinWeight = updateProductDto.MinWeight;
            product.Status = updateProductDto.Status;

            await _productDal.UpdateAsync(product);
        }

        public async Task TAddAsync(CreateProductDto createProductDto)
        {
            await _productDal.AddAsync(new Product()
            {
                ProductName = createProductDto.ProductName,
                Description = createProductDto.Description,
                Price = createProductDto.Price,
                ImagePath = createProductDto.ImagePath,
                SubCategoryId = createProductDto.SubCategoryId,
                ProductTitle = createProductDto.ProductTitle,
                Weight = createProductDto.Weight,
                CountryOfOrigin = createProductDto.CountryOfOrigin,
                Quality = createProductDto.Quality,
                Сheck = createProductDto.Сheck,
                MinWeight = createProductDto.MinWeight,
                Status = createProductDto.Status
            });
        }
    }
}
