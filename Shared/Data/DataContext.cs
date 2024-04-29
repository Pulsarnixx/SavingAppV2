using Webapp.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SavingEntity> Savings => Set<SavingEntity>();
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<SavingEntity>().HasData(
            new {Id = 1, Category = SavingCategory.Other, Name = "Bułki", Amount = 12.00m, Date = DateTime.Now},
            new {Id = 2, Category = SavingCategory.Other, Name = "Mydło", Amount = 5.00m, Date =  DateTime.Now.AddMinutes(30)},
            new {Id = 3, Category = SavingCategory.Other, Name = "Plecak", Amount = 1.00m, Date = DateTime.Now.AddHours(1)}
        );
    }
    }
}