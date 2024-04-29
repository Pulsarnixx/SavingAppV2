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

        public async Task<SavingEntity> AddExample(SavingEntity saving)
        {

            if (string.IsNullOrEmpty(saving.Name) || saving.Amount <= 0 || saving.Date == default)
            {
                throw new ArgumentException("Nieprawidłowe dane dla SavingEntity.");
            }
            _context.Savings.Add(saving);
            await _context.SaveChangesAsync();

            return saving;
        }

        public async Task<List<SavingEntity>> GetByCategory(SavingCategory category)
        {
            return await _context.Savings.Where(saving => saving.Category == category).ToListAsync();
        }
    }
}