using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TechRadarApi.BL.Interfaces;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RingController : ControllerBase
    {
        private readonly IRingRepository _ringRepository;

        public RingController(IRingRepository ringRepository)
        {
            _ringRepository = ringRepository;
        }

        [HttpGet]
        public Ring? GetRing([FromQuery]int id)
        {
            return _ringRepository.GetRingById(id);
        }

        [HttpGet]
        public List<Ring> GetRings()
        {
            return _ringRepository.GetRings();
        }
    }
}
