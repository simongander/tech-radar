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
        public List<Technology> GetTechnologiesInCategory([FromQuery]int categoryId)
        {
            return _technologyRepository.GetTechnologies(categoryId);
        }

        [HttpGet]
        public List<Technology> GetTechnologiesInCategoryRing([FromQuery] int categoryId, [FromQuery]int ringId)
        {
            return _technologyRepository.GetTechnologies(categoryId, ringId);
        }

        [HttpGet]
        public List<Technology> GetAllTechnologies()
        {
            return _technologyRepository.GetAllTechnologies();
        }

        [HttpPost]
        public Technology? AddTechnology([FromQuery]bool createNew, [FromBody] TechnologyDTO technology)
        {
            try
            {
                var savedTechnology = _technologyRepository.AddTechnology(createNew, technology);
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
