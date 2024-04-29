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
            new {Id = 1, Category = SavingCategory.Zakupy, Name = "Bułki", Amount = 12.00m, Date = DateTime.Now},
            new {Id = 2, Category = SavingCategory.Kosmetyki, Name = "Mydło", Amount = 5.00m, Date = DateTime.Now},
            new {Id = 3, Category = SavingCategory.Inne, Name = "Plecak", Amount = 1.00m, Date = DateTime.Now}
        );
    }
    }
}