using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.DAL
{
    public interface ITechRadarDbContext
    {
        DbSet<Technology> Technologies { get; set; }
        DbSet<Ring> Rings { get; set; }
        DbSet<Category> Categories { get; set; }
        int SaveChanges();
    }
}
