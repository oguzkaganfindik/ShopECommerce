using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.CategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult CategoryList()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(_categoryService.TGetAll());
            return Ok(value);
        }

        [HttpGet("SubCategoryCount")]
        public async Task<IActionResult> CategoryCount()
        {
            int count = await _categoryService.TCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("ActiveSubCategoryCount")]
        public async Task<IActionResult> ActiveCategoryCount()
        {
            int count = await _categoryService.TActiveCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("PassiveSubCategoryCount")]
        public async Task<IActionResult> PassiveCategoryCount()
        {
            int count = await _categoryService.TPassiveCategoryCountAsync();
            return Ok(count);
        }

        [HttpPost]
        public IActionResult CreateCategory(CreateCategoryDto createCategoryDto)
        {
            _categoryService.TAdd(new Category()
            {
                CategoryName = createCategoryDto.CategoryName,
                Status = true
            });

            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            _categoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetCategory(int id)
        {
            var value = _categoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateCategory(UpdateCategoryDto updateCategoryDto)
        {
            _categoryService.TUpdate(new Category()
            {
                CategoryName = updateCategoryDto.CategoryName,
                Id = updateCategoryDto.Id,
                Status = updateCategoryDto.Status,
            });

            return Ok("Kategori Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _categoryService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_categoryService.TGetListByStatusTrue());
        }
    }
}
