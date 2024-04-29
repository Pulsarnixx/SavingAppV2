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

        public async Task<SavingEntity> GetSavingById(int id)
        {
           return await _context.Savings.FindAsync(id);
        }

        public async Task<SavingEntity> EditSaving(int id, SavingEntity saving)
        {
           var dbsaving = await _context.Savings.FindAsync(id);
            if(dbsaving != null)
            {
                dbsaving.Name = saving.Name;
                await _context.SaveChangesAsync();
                return dbsaving;
            }
            throw new Exception("Game not found.");
        }

        public async Task<bool> DeleteSaving(int id)
        {
            var dbsaving = await _context.Savings.FindAsync(id);
            if(dbsaving != null)
            {
                _context.Remove(dbsaving);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }
    }
}