using Webapp.Shared.Entities;
using Webapp.Shared.Data;
using Webapp.Shared.Services;
using Microsoft.EntityFrameworkCore;
using System.Net.Http.Json;

namespace Webapp.Shared.Services
{
    public class ClientExampleService : IExampleService
    {

        private readonly HttpClient _httpClient;

        public ClientExampleService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<Example> AddExample(Example example)
        {
            var result = await _httpClient.PostAsJsonAsync(
                                "/api/example",example);

            return await result.Content.ReadFromJsonAsync<Example>();
        }

        public async Task<bool> DeleteExample(int id)
        {
            var result = await _httpClient.DeleteAsync($"api/example/{id}");
            return await result.Content.ReadFromJsonAsync<bool>();
        }

        public async Task<Example> EditExample(int id, Example example)
        {
            var result = await _httpClient.PutAsJsonAsync($"api/example/{id}",example);
             return await result.Content.ReadFromJsonAsync<Example>();
        }

        public async Task<List<Example>> GetAllExamples()
        {
           throw new NotImplementedException();
        }

        public async Task<Example> GetExampleById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<Example>($"api/example/{id}");
            return result;
        }
    }
}