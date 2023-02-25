using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechRadarApi.BL.Interfaces;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.Controllers
{
    [Route("api/[controller]")]
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
        public List<Technology> GetTechnologies([FromQuery]int id, [FromQuery]int categoryId)
        {
            return GetTechnologies(id, categoryId);
        }

        [HttpGet]
        public List<Technology> GetTechnologies([FromQuery] int id, [FromQuery] int categoryId, [FromQuery]int ringId)
        {
            return GetTechnologies(id, categoryId, ringId);
        }

        [HttpPost]
        public Technology? AddTechnology([FromBody] Technology technology)
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
