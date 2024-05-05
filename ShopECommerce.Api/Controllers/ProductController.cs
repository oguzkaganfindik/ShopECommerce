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
                ImageUrl = createProductDto.ImageUrl,
                Price = createProductDto.Price,
                SubCategoryId = createProductDto.SubCategoryId,
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

        [HttpPut]
        public IActionResult UpdateProduct(UpdateProductDto updateProductDto)
        {
            _productService.TUpdate(new Product()
            {
                Id = updateProductDto.Id,
                ProductName = updateProductDto.ProductName,
                Description = updateProductDto.Description,
                ImageUrl = updateProductDto.ImageUrl,
                Price = updateProductDto.Price,
                SubCategoryId = updateProductDto.SubCategoryId,
                Status = updateProductDto.Status
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

        [HttpGet("ProductAvgPriceByHamburger")]
        public IActionResult ProductAvgPriceByHamburger()
        {
            return Ok(_productService.TProductAvgPriceByHamburger());
        }

        [HttpGet("ProductCountByDrink")]
        public IActionResult ProductCountByDrink()
        {
            return Ok(_productService.TProductCountBySubCategoryNameDrink());
        }

        [HttpGet("ProductPriceAvg")]
        public IActionResult ProductPriceAvg()
        {
            return Ok(_productService.TProductPriceAvg());
        }

        [HttpGet("ProductCountByHamburger")]
        public IActionResult ProductCountByHamburger()
        {
            return Ok(_productService.TProductCountBySubCategoryNameHamburger());
        }     

        [HttpGet("ProductPriceBySteakBurger")]
        public IActionResult ProductPriceBySteakBurger()
        {
            return Ok(_productService.TProductPriceBySteakBurger());
        }

        [HttpGet("TotalPriceByDrinkSubCategory")]
        public IActionResult TotalPriceByDrinkSubCategory()
        {
            return Ok(_productService.TTotalPriceByDrinkSubCategory());
        }

        [HttpGet("TotalPriceBySaladSubCategory")]
        public IActionResult TotalPriceBySaladSubCategory()
        {
            return Ok(_productService.TTotalPriceBySaladSubCategory());
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
            var result = _mapper.Map<List<ResultProductWithCategory>>(values);
            return Ok(result);
        }
        
        [HttpGet("GetProductListByFruites")]
        public IActionResult GetProductListByFruites()
        {
            var values = _productService.TGetProductListByFruites();
            var result = _mapper.Map<List<ResultProductWithCategory>>(values);
            return Ok(result);
        }
    }
}
