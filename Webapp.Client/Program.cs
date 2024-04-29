using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Webapp.Shared.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),


});

await builder.Build().RunAsync();
