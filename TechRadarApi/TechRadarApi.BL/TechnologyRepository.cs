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
    }
}
