using Microsoft.Extensions.DependencyInjection;
using Nethereum.Web3;
using Savitar.WebAssembly.Blockchain.Ethereum.Services;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using System;

namespace Savitar.WebAssembly.Blockchain.Ethereum
{
    public static class DI
    {
        public static IServiceCollection AddSavitarBlockchainEthereumServices(this IServiceCollection services, string infuraApiKey)
        {
            if (string.IsNullOrEmpty(infuraApiKey))
                throw new ArgumentNullException(nameof(infuraApiKey));

            services.AddSingleton<IWeb3>(ctx => new Web3($"https://mainnet.infura.io/v3/{infuraApiKey}"));
            services.AddSingleton<IEthereumService, EthereumService>();

            //services.AddSingleton<IMetamaskInterop, MetamaskBlazorInterop>();
            //services.AddSingleton<MetamaskInterceptor>();
            //services.AddSingleton<MetamaskHostProvider>();
            //services.AddSingleton<IEthereumHostProvider>(serviceProvider =>
            //{
            //    return serviceProvider.GetService<MetamaskHostProvider>();
            //});
            //services.AddSingleton<NethereumAuthenticator>();
            //services.AddValidatorsFromAssemblyContaining<Erc20Transfer>();

            return services;
        }
    }
}
