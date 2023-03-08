using Microsoft.AspNetCore.Mvc;
using MyCourse.Service.Catalog.Dtos;
using MyCourse.Service.Catalog.Services;
using MyCourse.Shared.ControllerBases;
using System.Threading.Tasks;

namespace MyCourse.Service.Catalog.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : CustomBaseController
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _categoryService.GetAllAsync();
            return CreateActionResultInstance(response);
        }

        [HttpGet("GetById/{id}")]
        public async Task<IActionResult> GetById(string id)
        {
            var response = await _categoryService.GetByIdAsync(id);
            return CreateActionResultInstance(response);
        }
        [HttpGet("GetAllByUserId/{userId}")]
        public async Task<IActionResult> GetAllByUserId(string userId)
        {
            var response = await _categoryService.GetByIdAsync(userId);
            return CreateActionResultInstance(response);
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(CategoryCreateDto categorCreateyDto)
        {
            var response = await _categoryService.CreateAsync(categorCreateyDto);
            return CreateActionResultInstance(response);
        }

        [HttpPut("Update")]
        public async Task<IActionResult> Update(CategoryUpdateDto categoryUpdateDto)
        {
            var response = await _categoryService.UpdateAsync(categoryUpdateDto);
            return CreateActionResultInstance(response);
        }

        [HttpDelete("Delete/{id}")]
        public async Task<IActionResult> Delete(string id)
        {
            var response = await _categoryService.DeleteAsync(id);
            return CreateActionResultInstance(response);
        }
    }
}
