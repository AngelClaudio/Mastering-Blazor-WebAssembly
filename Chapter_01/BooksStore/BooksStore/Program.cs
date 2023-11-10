using BooksStore;
using BooksStore.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

// WebAssembyHostBuilder.Services.AddScoped method is the DI container where you register your services.
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

// In the below case, the ConsoleLoggingService implementation, is registered for ILoggingService
builder.Services.AddScoped<ILoggingService, ConsoleLoggingService>();

await builder.Build().RunAsync();
