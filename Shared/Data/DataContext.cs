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
            new {Id = 1, Category = SavingCategory.Income, Name = "Salary 1", Amount = 590m, Date = DateTime.Now},
            new {Id = 2, Category = SavingCategory.Income, Name = "Salary 2", Amount = 640m, Date = DateTime.Now.AddMonths(1)},
            new {Id = 3, Category = SavingCategory.Savings, Name = "Saving 1", Amount = 20.00m, Date = DateTime.Now.AddHours(1)},
            new {Id = 4, Category = SavingCategory.Savings, Name = "Saving 2", Amount = 35.00m, Date = DateTime.Now.AddMonths(1).AddDays(1)},
            new {Id = 5, Category = SavingCategory.Other, Name = "Books", Amount = 62.00m, Date = DateTime.Now.AddHours(2)},
            new {Id = 6, Category = SavingCategory.Other, Name = "Toys", Amount = 93.00m, Date = DateTime.Now.AddMonths(1).AddDays(2)}
        );
    }
    }
}