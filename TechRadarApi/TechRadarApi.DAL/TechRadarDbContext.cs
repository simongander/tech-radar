using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechRadarApi.DAL.Model;

namespace TechRadarApi.DAL
{
    public class TechRadarDbContext : DbContext, ITechRadarDbContext
    {
        private readonly string connStr;

        public TechRadarDbContext(string connStr)
        {
            this.connStr = connStr;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySQL(connStr);
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Technology>()
                .HasOne(r => r.Ring)
                .WithMany(t => t.Technologies);
        }

        public DbSet<Technology> Technologies { get; set; }
        public DbSet<Ring> Rings { get; set; }
        public DbSet<Category> Categories { get; set; }

        public override int SaveChanges()
        {
            return base.SaveChanges();
        }
    }
}
