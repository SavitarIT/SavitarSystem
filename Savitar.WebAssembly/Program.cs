using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Serilog;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using Savitar.WebAssembly.Services.Contracts;
using Savitar.WebAssembly.Services.Implementations;

namespace Savitar.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            builder.Services.AddOptions();
            builder.Services.AddAuthorizationCore();
            builder.Services.AddScoped<IdentityAuthenticationStateProvider>();
            builder.Services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
            builder.Services.AddScoped<IAuthorizeApi, AuthorizeApi>();

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Debug()
                .WriteTo.BrowserConsole()
                .CreateLogger();
            

            ConfigureServices(builder);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddScoped<IAccountsApi, AccountsApi>();
            builder.Services.AddMudServices();            
        }
    }
}
