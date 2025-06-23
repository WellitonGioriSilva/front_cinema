using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using front_cinema.Client.Localization;
using MudBlazor;
using System.Globalization;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");
CultureInfo.DefaultThreadCurrentUICulture = new CultureInfo("pt-BR");

builder.Services.AddMudServices().AddTransient<MudLocalizer, PortugueseMudLocalizer>();
// builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped(sp => new HttpClient
{
    BaseAddress = new Uri("http://localhost:5037/")
});


await builder.Build().RunAsync();
