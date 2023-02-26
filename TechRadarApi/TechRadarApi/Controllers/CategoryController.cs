using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechRadarApi.BL.Interfaces;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public Category? GetCategory([FromQuery]int id)
        {
            return _categoryRepository.GetCategoryById(id);
        }

        [HttpGet]
        public List<Category> GetCategories()
        {
            return _categoryRepository.GetCategories();
        }
    }
}
