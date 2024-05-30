using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.CategoryDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoriesController(ICategoryService categoryService, IMapper mapper)
        {
            _categoryService = categoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryListAsync()
        {
            var value = _mapper.Map<List<ResultCategoryDto>>(await _categoryService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("SubCategoryCount")]
        public async Task<IActionResult> CategoryCountAsync()
        {
            int count = await _categoryService.TCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("ActiveSubCategoryCount")]
        public async Task<IActionResult> ActiveCategoryCountAsync()
        {
            int count = await _categoryService.TActiveCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("PassiveSubCategoryCount")]
        public async Task<IActionResult> PassiveCategoryCountAsync()
        {
            int count = await _categoryService.TPassiveCategoryCountAsync();
            return Ok(count);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategoryAsync(CreateCategoryDto createCategoryDto)
        {
            await _categoryService.TAddAsync(createCategoryDto);
            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategoryAsync(int id)
        {
            var value = await _categoryService.TGetByIdAsync(id);
            await _categoryService.TDeleteAsync(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoryAsync(int id)
        {
            var value = await _categoryService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateCategoryAsync(UpdateCategoryDto updateCategoryDto)
        {
            await _categoryService.TUpdateAsync(updateCategoryDto);
            return Ok("Kategori Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _categoryService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _categoryService.TGetListByStatusTrueAsync());
        }
    }
}
