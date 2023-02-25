using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.BL.Interfaces;
using TechRadarApi.DAL;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.BL
{
    public class TechnologyRepository : ITechnologyRepository
    {
        private readonly ITechRadarDbContext _context;

        public TechnologyRepository(ITechRadarDbContext context)
        {
            _context = context;
        }

        public Technology? GetTechnologyById(int id)
        {
            var technologies = _context.Technologies.Where(t => t.TechnologyId == id).ToList();
            if(technologies.Count == 0)
            {
                return null;
            }

            return technologies.First();
        }

        public List<Technology> GetTechnologies(int id, int categoryId)
        {
            return _context.Technologies.Where(t => t.TechnologyId == id && t.CategoryId == categoryId).ToList();
        }

        public List<Technology> GetTechnologies(int id, int categoryId, int ringId)
        {
            return _context.Technologies.Where(t => t.TechnologyId == id && t.CategoryId == categoryId && t.RingId == ringId).ToList();
        }

        public Technology AddTechnology(Technology technology)
        {
            if (IsTechnologyValid(technology))
            {
                var entity = _context.Technologies.Add(technology);
                return entity.Entity;
            }

            throw new ArgumentException("Invalid data in technology");
        }

        private bool IsTechnologyValid(Technology technology)
        {
            if (technology.CategoryId == 0)
            {
                return false;
            }
            if (string.IsNullOrEmpty(technology.Description))
            {
                return false;
            }
            if (string.IsNullOrEmpty(technology.Name) && technology.Name.Length <= 255)
            {
                return false;
            }
            return true;
        }
    }
}
