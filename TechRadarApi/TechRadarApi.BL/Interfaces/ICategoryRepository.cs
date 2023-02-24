using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.BL.Interfaces
{
    public interface ICategoryRepository
    {
        Category? GetCategoryById(int id);
    }
}
