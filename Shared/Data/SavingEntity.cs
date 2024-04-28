using Webapp.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Shared.Data
{
    public class SavingEntityContext : DbContext
    {
        public SavingEntityContext(DbContextOptions<SavingEntityContext> options)
            :base(options)
        {

        }

        public DbSet<SavingEntity> Savings { get; set; }
    }
}