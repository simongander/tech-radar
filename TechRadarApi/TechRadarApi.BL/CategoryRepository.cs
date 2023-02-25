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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ITechRadarDbContext _context;

        public CategoryRepository(ITechRadarDbContext context)
        {
            _context = context;
        }

        public Category? GetCategoryById(int id)
        {
            var categories = _context.Categories.Where(c => c.CategoryId == id);

            if(categories.Count() == 0)
            {
                return null;
            }

            return categories.First();
        }

        public List<Category> GetCategories()
        {
            return _context.Categories.ToList();
        }
    }
}
