using Webapp.Shared.Entities;
using Webapp.Shared.Data;
using Microsoft.EntityFrameworkCore;

namespace Webapp.Shared.Services
{
    public class ExampleService : IExampleService
    {
        private readonly DataContext  _context;

        public ExampleService(DataContext context)
        {
            _context = context;
        }

        public async Task<List<Example>> GetAllExamples()
        {
            await Task.Delay(1000); 

            var examples = await _context.Examples.ToListAsync();
            return examples;
        }

        public async Task<Example> AddExample(Example example)
        {
            _context.Examples.Add(example);
            await _context.SaveChangesAsync();

            return example;
        }

        public async Task<Example> GetExampleById(int id)
        {
            return await _context.Examples.FindAsync(id);
        }

        public async Task<Example> EditExample(int id, Example example)
        {
            var dbExample = await _context.Examples.FindAsync(id);
            if(dbExample != null)
            {
                dbExample.Name = example.Name;
                await _context.SaveChangesAsync();
                return dbExample;
            }

            throw new Exception("Example object doesnt exist!");
        }

        public async Task<bool> DeleteExample(int id)
        {
            var dbExample = await _context.Examples.FindAsync(id);
            if(dbExample != null)
            {
                _context.Remove(dbExample);
                await _context.SaveChangesAsync();
                return true;
            }

            return false;
        }
    }
}