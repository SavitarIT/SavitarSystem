using Microsoft.Extensions.DependencyInjection;
using Nethereum.Web3;
using Savitar.WebAssembly.Blockchain.Ethereum.Services;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using FluentValidation;
using Savitar.WebAssembly.Blockchain.Ethereum.Metamask;

namespace Savitar.WebAssembly.Blockchain.Ethereum
{
    public static class DI
    {
        public static IServiceCollection AddSavitarBlockchainEthereumServices(this IServiceCollection services)
        {            
            services.AddSingleton<IWeb3>(ctx => new Web3("https://mainnet.infura.io/v3/7238211010344719ad14a89db874158c"));
            services.AddSingleton<IEthereumService, EthereumService>();


            services.AddSingleton<IMetamaskInterop, MetamaskBlazorInterop>();
            services.AddSingleton<MetamaskInterceptor>();
            services.AddSingleton<MetamaskHostProvider>();
            services.AddSingleton<IEthereumHostProvider>(serviceProvider =>
            {
                return serviceProvider.GetService<MetamaskHostProvider>();
            });
            services.AddSingleton<NethereumAuthenticator>();
            services.AddValidatorsFromAssemblyContaining<Erc20Transfer>();

            return services;
        }
    }
}
