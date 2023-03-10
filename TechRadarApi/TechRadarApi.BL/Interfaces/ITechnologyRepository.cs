using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.BL.Data;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.BL.Interfaces
{
    public interface ITechnologyRepository
    {
        Technology? GetTechnologyById(int id);
        List<Technology> GetTechnologies(int categoryId);
        List<Technology> GetTechnologies(int categoryId, int ringId);
        Technology AddTechnology(bool createNew, TechnologyDTO technology);
        List<Technology> GetAllTechnologies();
    }
}
