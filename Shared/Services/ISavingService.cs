using Webapp.Shared.Entities;

namespace Webapp.Shared.Services
{
    public interface ISavingService
    {
        public Task<List<SavingEntity>> GetAllExamples();
        public Task<SavingEntity> AddExample(SavingEntity saving);
        public Task<List<SavingEntity>> GetByCategory(SavingCategory category);

        public Task<SavingEntity> GetSavingById(int id);

        public Task<SavingEntity> EditSaving(int id, SavingEntity saving);

        public Task<bool> DeleteSaving(int id);
        

        
    }
}