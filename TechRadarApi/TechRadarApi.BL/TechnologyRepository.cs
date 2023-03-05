using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.BL.Data;
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

        public List<Technology> GetTechnologies(int categoryId)
        {
            return _context.Technologies.Where(t => t.CategoryId == categoryId && t.IsPublished).ToList();
        }

        public List<Technology> GetTechnologies(int categoryId, int ringId)
        {
            return _context.Technologies.Where(t => t.CategoryId == categoryId && t.RingId == ringId && t.IsPublished).ToList();
        }

        public List<Technology> GetAllTechnologies()
        {
            return _context.Technologies.OrderBy(t => t.CategoryId).ThenBy(t => t.RingId).ToList();
        }

        public Technology AddTechnology(bool createNew, TechnologyDTO technology)
        {
            if (IsTechnologyValid(technology, createNew))
            {
                if (createNew)
                {
                    var entity = _context.Technologies.Add(ConvertTechnology(technology, createNew));
                    _context.SaveChanges();
                    return entity.Entity;
                }
                else
                {
                    var entities = _context.Technologies.Where(t => t.TechnologyId == technology.TechnologyId);
                    if(entities.Count() == 0)
                    {
                        throw new ArgumentException($"No entity with id { technology.TechnologyId } found");
                    }

                    var entity = entities.First();
                    entity.Name = technology.Name;
                    entity.Description =  technology.Description;
                    entity.Explanation = technology.Explanation;
                    entity.IsPublished = technology.IsPublished;
                    entity.CategoryId = technology.CategoryId;
                    entity.RingId = technology.RingId;
                    var updatedEntity = _context.Technologies.Update(entity);
                    _context.SaveChanges();
                    return updatedEntity.Entity;
                }
            }

            throw new ArgumentException("Invalid data in technology");
        }

        private bool IsTechnologyValid(TechnologyDTO technology, bool createNew)
        {
            if (!createNew)
            {
                if(technology.TechnologyId == null || technology.TechnologyId == 0)
                {
                    return false;
                }
            }
            if (technology.CategoryId == 0)
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(technology.Description))
            {
                return false;
            }
            if (string.IsNullOrWhiteSpace(technology.Name) && technology.Name.Length <= 255)
            {
                return false;
            }
            return true;
        }

        private Technology ConvertTechnology(TechnologyDTO technology, bool createNew)
        {
            var tech = new Technology
            { 
                Name = technology.Name,
                Description = technology.Description,
                Explanation = technology.Explanation,
                IsPublished = technology.IsPublished,
                CategoryId = technology.CategoryId,
                RingId = technology?.RingId                
            };
            if (!createNew)
            {
                tech.TechnologyId = technology.TechnologyId.Value;
            }
            return tech;
        }
    }
}
