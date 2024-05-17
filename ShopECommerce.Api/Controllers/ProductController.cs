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
        public IActionResult ProductListWithSubCategory()
        {
            var values = _productService.TGetProductsWithSubCategories();
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
        public IActionResult GetProductShowcaseDetailId(int id)
        {
            var value = _productService.TGetProductShowcaseDetailId(id);
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
        public IActionResult ProductCount()
        {
            return Ok(_productService.TProductCount());
        }

        [HttpGet("ProductNameByMaxPrice")]
        public IActionResult ProductNameByMaxPrice()
        {
            return Ok(_productService.TProductNameByMaxPrice());
        }

        [HttpGet("ProductNameByMinPrice")]
        public IActionResult ProductNameByMinPrice()
        {
            return Ok(_productService.TProductNameByMinPrice());
        }

        [HttpGet("ProductAvgPriceByApple")]
        public IActionResult ProductAvgPriceByApple()
        {
            return Ok(_productService.TProductAvgPriceByApple());
        }

        [HttpGet("ProductCountByTomato")]
        public IActionResult ProductCountByTomato()
        {
            return Ok(_productService.TProductCountBySubCategoryNameTomato());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }

        [HttpGet("ProductCountByApple")]
        public IActionResult ProductCountByApple()
        {
            return Ok(_productService.TProductCountBySubCategoryNameApple());
        }

        [HttpGet("ProductPriceByNativeOranges")]
        public IActionResult ProductPriceByNativeOranges()
        {
            return Ok(_productService.TProductPriceByNativeOranges());
        }

        [HttpGet("TotalPriceByTomatoSubCategory")]
        public IActionResult TotalPriceByTomatoSubCategory()
        {
            return Ok(_productService.TTotalPriceByTomatoSubCategory());
        }

        [HttpGet("TotalPriceByStrawberrySubCategory")]
        public IActionResult TotalPriceByStrawberrySubCategory()
        {
            return Ok(_productService.TTotalPriceByStrawberrySubCategory());
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
        public IActionResult GetProductListByVegetable()
        {
            var values = _productService.TGetProductListByVegetable();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }

        [HttpGet("GetProductListByFruites")]
        public IActionResult GetProductListByFruites()
        {
            var values = _productService.TGetProductListByFruites();
            var result = _mapper.Map<List<ResultProductWithSubCategory>>(values);
            return Ok(result);
        }
    }
}
