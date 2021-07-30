using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using Savitar.Web.Bootstrapper;
using Savitar.WebAssembly.Blockchain.Ethereum;
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

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddMudServices();
            builder.Services.AddSavitarServices();
            builder.Services.AddSavitarBlockchainEthereumServices();

            await builder.Build().RunAsync();
        }
    }
}
