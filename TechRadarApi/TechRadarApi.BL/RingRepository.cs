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
    public class RingRepository : IRingRepository
    {
        private readonly ITechRadarDbContext _context;

        public RingRepository(ITechRadarDbContext context)
        {
            _context = context;
        }

        public Ring? GetRingById(int id)
        {
            var rings = _context.Rings.Where(r => r.RingId == id);
            if(rings.Count() == 0)
            {
                return null;
            }

            return rings.First();

        }
    }
}
