using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechRadarApi.BL.Data;
using TechRadarApi.BL.Interfaces;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TechnologyController : ControllerBase
    {
        private readonly ITechnologyRepository _technologyRepository;

        public TechnologyController(ITechnologyRepository technologyRepository)
        {
            _technologyRepository = technologyRepository;
        }

        [HttpGet]
        public Technology? GetTechnology([FromQuery]int id)
        {
            return _technologyRepository.GetTechnologyById(id);
        }

        [HttpGet]
        public List<Technology> GetTechnologiesInCategory([FromQuery]int id, [FromQuery]int categoryId)
        {
            return _technologyRepository.GetTechnologies(id, categoryId);
        }

        [HttpGet]
        public List<Technology> GetTechnologiesInCategoryRing([FromQuery] int id, [FromQuery] int categoryId, [FromQuery]int ringId)
        {
            return _technologyRepository.GetTechnologies(id, categoryId, ringId);
        }

        [HttpPost]
        public Technology? AddTechnology([FromBody] TechnologyDTO technology)
        {
            try
            {
                var savedTechnology = _technologyRepository.AddTechnology(technology);
                return savedTechnology;
            }
            catch (ArgumentException)
            {
                Response.StatusCode = 400;
                return null;
            }
        }
    }
}
