using Webapp.Shared.Entities;
using Webapp.Shared.Data;
using Microsoft.EntityFrameworkCore;


/*
                SERVER SERVICE IMPLEMENTATION
================================================================
*/
namespace Webapp.Shared.Services
{
    public class SavingService : ISavingService
    {
        private readonly DataContext  _context;

        public SavingService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<SavingEntity>> GetAllExamples()
        {
            await Task.Delay(1000); 

            var savings = await _context.Savings.ToListAsync();
            return savings;
        }

    }
}