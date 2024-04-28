using Webapp.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Shared.Data
{
    public class SavingTypeContext : DbContext
    {
        public SavingTypeContext(DbContextOptions<SavingTypeContext> options)
            :base(options)
        {

        }

        public DbSet<SavingType> SavingTypes { get; set; }
    }
}