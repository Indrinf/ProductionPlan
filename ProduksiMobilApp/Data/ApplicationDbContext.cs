using Microsoft.EntityFrameworkCore;
using ProduksiMobilApp.Models;
using System.Collections.Generic;

namespace ProduksiMobilApp.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<ProductionPlan> ProductionPlans { get; set; }
    }
}