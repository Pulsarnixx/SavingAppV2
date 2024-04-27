using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Webapp.Shared.Entities;
using Webapp.Shared.Services;

namespace Webapp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExampleController : ControllerBase
    {
        private readonly IExampleService _exampleService;
        public ExampleController(IExampleService exampleService)
        {
            _exampleService = exampleService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Example>> GetExampleById(int id)
        {
            var example = await _exampleService.GetExampleById(id);
            return Ok(example);
        }

        [HttpPost]
        public async Task<ActionResult<Example>> AddExamples(Example example)
        {
            var addedExample = await _exampleService.AddExample(example);
            return Ok(addedExample);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult<Example>> EditExample(int id, Example example)
        {
            var updatedExample = await _exampleService.EditExample(id,example);
            return Ok(updatedExample);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Example>> DeleteExample(int id)
        {
            var deletedExample = await _exampleService.DeleteExample(id);
            return Ok(deletedExample);
        }
        
    }
}