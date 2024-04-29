using Webapp.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Shared.Data
{
    public class DataContext : DbContext
    {
        public DataContext() { }
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<SavingEntity> Savings => Set<SavingEntity>();
        public DbSet<SavingType> SavingTypes => Set<SavingType>();
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<SavingType>().HasData(
            new {Id = 1, Name = "Grocery"},
            new {Id = 2, Name = "Shopping"},
            new {Id = 3, Name = "Subscriptions"}
        );
    }

        public DbSet<Example> Examples { get; set; }
    }
}