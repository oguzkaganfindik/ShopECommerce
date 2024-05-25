using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.ProductDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public ProductController(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ProductList()
        {
            var value = _mapper.Map<List<ResultProductDto>>(_productService.TGetListAll());
            return Ok(value);
        }

        [HttpGet("ProductListWithSubCategory")]
        public async Task<IActionResult> ProductListWithSubCategory()
        {
            var values = await _productService.TGetProductsWithSubCategoriesAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }


        [HttpPost]
        public IActionResult CreateProduct(CreateProductDto createProductDto)
        {
            _productService.TAdd(new Product()
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
        public IActionResult GetProduct(int id)
        {
            var value = _productService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("GetProductShowcaseDetailId/{id}")]
        public async Task<IActionResult> GetProductShowcaseDetailIdAsync(int id)
        {
            var value = await _productService.TGetProductShowcaseDetailIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
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
        public IActionResult DeleteProduct(int id)
        {
            var value = _productService.TGetById(id);
            _productService.TDelete(value);
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
        public IActionResult ToggleStatus(int id)
        {
            _productService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_productService.TGetListByStatusTrue());
        }

        [HttpGet("GetProductListByVegetable")]
        public async Task<IActionResult> GetProductListByVegetable()
        {
            var values = await _productService.TGetProductListByVegetableAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }


        [HttpGet("GetProductListByFruites")]
        public async Task<IActionResult> GetProductListByFruites()
        {
            var values = await _productService.TGetProductListByFruitesAsync();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }

    }
}
