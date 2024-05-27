using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductsController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ProductListAsync()
        {
            var value = _mapper.Map<List<ResultProductDto>>(await _productService.TGetListAllAsync());
            return Ok(value);
        }

        [HttpGet("ProductListWithSubCategory")]
        public async Task<IActionResult> ProductListWithSubCategoryAsync()
        {
            var values = await _productService.TGetProductsWithSubCategoriesAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }


        [HttpPost]
        public async Task<IActionResult> CreateProductAsync(CreateProductDto createProductDto)
        {
            await _productService.TAddAsync(new Product()
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

            return Ok("Ürün Bilgisi Eklendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductAsync(int id)
        {
            var value = await _productService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpGet("GetProductShowcaseDetailId/{id}")]
        public async Task<IActionResult> GetProductShowcaseDetailIdAsync(int id)
        {
            var value = await _productService.TGetProductShowcaseDetailIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProductAsync(UpdateProductDto updateProductDto)
        {
            await _productService.TUpdateAsync(new Product()
            {
                Id = updateProductDto.Id,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                ImagePath = updateProductDto.ImagePath,
                Price = updateProductDto.Price,
                SubCategoryId = updateProductDto.SubCategoryId,
                Status = updateProductDto.Status,
                ProductTitle = updateProductDto.ProductTitle,
                Weight = updateProductDto.Weight,
                CountryOfOrigin = updateProductDto.CountryOfOrigin,
                Quality = updateProductDto.Quality,
                Сheck = updateProductDto.Сheck,
                MinWeight = updateProductDto.MinWeight,
            });

            return Ok("Ürün Bilgisi Güncellendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProductAsync(int id)
        {
            var value = await _productService.TGetByIdAsync(id);
            await _productService.TDeleteAsync(value);
            return Ok("Ürün Bilgisi Silindi");
        }

        [HttpGet("ProductCount")]
        public async Task<IActionResult> ProductCountAsync()
        {
            return Ok(await _productService.TProductCountAsync());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public async Task<IActionResult> ProductNameByMaxPriceAsync()
        {
            return Ok(await _productService.TProductNameByMaxPriceAsync());
        }

        [HttpGet("ProductNameByMinPrice")]
        public async Task<IActionResult> ProductNameByMinPriceAsync()
        {
            return Ok(await _productService.TProductNameByMinPriceAsync());
        }

        [HttpGet("ProductAvgPriceByApple")]
        public async Task<IActionResult> ProductAvgPriceByAppleAsync()
        {
            return Ok(await _productService.TProductAvgPriceByAppleAsync());
        }

        [HttpGet("ProductCountByTomato")]
        public async Task<IActionResult> ProductCountByTomatoAsync()
        {
            return Ok(await _productService.TProductCountBySubCategoryNameTomatoAsync());
        }

        [HttpGet("ProductPriceAvg")]
        public async Task<IActionResult> ProductPriceAvgAsync()
        {
            return Ok(await _productService.TProductPriceAvgAsync());
        }

        [HttpGet("ProductCountByApple")]
        public async Task<IActionResult> ProductCountByAppleAsync()
        {
            return Ok(await _productService.TProductCountBySubCategoryNameAppleAsync());
        }

        [HttpGet("ProductPriceByNativeOranges")]
        public async Task<IActionResult> ProductPriceByNativeOrangesAsync()
        {
            return Ok(await _productService.TProductPriceByNativeOrangesAsync());
        }

        [HttpGet("TotalPriceByTomatoSubCategory")]
        public async Task<IActionResult> TotalPriceByTomatoSubCategoryAsync()
        {
            return Ok(await _productService.TTotalPriceByTomatoSubCategoryAsync());
        }

        [HttpGet("TotalPriceByStrawberrySubCategory")]
        public async Task<IActionResult> TotalPriceByStrawberrySubCategoryAsync()
        {
            return Ok(await _productService.TTotalPriceByStrawberrySubCategoryAsync());
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _productService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _productService.TGetListByStatusTrueAsync());
        }

        [HttpGet("GetProductListByVegetable")]
        public async Task<IActionResult> GetProductListByVegetableAsync()
        {
            var values = await _productService.TGetProductListByVegetableAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }


        [HttpGet("GetProductListByFruites")]
        public async Task<IActionResult> GetProductListByFruitesAsync()
        {
            var values = await _productService.TGetProductListByFruitesAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }

    }
}
