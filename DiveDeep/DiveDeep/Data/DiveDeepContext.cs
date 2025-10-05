using DiveDeep.Models;
using Microsoft.EntityFrameworkCore;

namespace DiveDeep.Data
{
    public class DiveDeepContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var m = modelBuilder.Entity<Product>();
            m.OwnsOne(p => p.DivingSuit);
            m.OwnsOne(p => p.BCD);
            m.OwnsOne(p => p.Fins);
            m.OwnsOne(p => p.OxygenTank);
            m.OwnsOne(p => p.Regulator);
            m.OwnsOne(p => p.MaskSnorkel);
        }
    }
}
