using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using front_cinema.Client.Localization;
using MudBlazor;


var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices().AddTransient<MudLocalizer, PortugueseMudLocalizer>();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

await builder.Build().RunAsync();
