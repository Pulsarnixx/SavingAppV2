using Webapp.Shared.Entities;

namespace Webapp.Shared.Services
{
    public interface IExampleService
    {
        public Task<List<Example>> GetAllExamples();
        public Task<Example> AddExample(Example example);

        public Task<Example> GetExampleById(int id);

        public Task<Example> EditExample(int id, Example example);

        public Task<bool> DeleteExample(int id);
        

        
    }
}