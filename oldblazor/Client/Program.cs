using FriendsNess.Client;
using FriendsNess.Client.Http;
using FriendsNess.Client.Http.Services;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Authentication;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddHttpClient("FriendsNess.ServerAPI", client => client.BaseAddress = new Uri(builder.HostEnvironment.BaseAddress))
    .AddHttpMessageHandler<BaseAddressAuthorizationMessageHandler>();
// Supply HttpClient instances that include access tokens when making requests to the server project
builder.Services.AddScoped(sp => sp.GetRequiredService<IHttpClientFactory>().CreateClient("FriendsNess.ServerAPI"));

builder.Services.AddScoped<IRepository, Repository>();
// Http Services
builder.Services.AddScoped<IExercicesService, ExercicesService>();

builder.Services.AddApiAuthorization();
builder.Services.AddMudServices();

await builder.Build().RunAsync();
