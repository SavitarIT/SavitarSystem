using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Savitar.Bootstrapper;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Savitar.WebAssembly
{
    public class Program
    {
        public static async Task Main(string[] args)
        {            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");

            var baseAddress = builder.HostEnvironment.BaseAddress; //.Replace("http:", "https:");
            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(baseAddress) });

            ConfigureServices(builder);

            await builder.Build().RunAsync();
        }

        public static void ConfigureServices(WebAssemblyHostBuilder builder)
        {
            builder.Services.AddMudServices();
            builder.Services.AddSavitarServices();
        }
    }
}
