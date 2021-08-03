using Nethereum.Web3;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using System.Threading.Tasks;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Services
{
    internal class EthereumService : IEthereumService
    {
        private readonly IWeb3 _web3;

        public EthereumService(IWeb3 web3)
        {
            _web3 = web3;
        }

        public async Task<decimal> GetLatestBlockNumberAsync()
        {            
            var result = await _web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
            return (decimal)result.Value;            
        }   

        public async Task<decimal> GetBalanceAsync(string ethWalletAddress = "0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae")
        {            
            var balance = await _web3.Eth.GetBalance.SendRequestAsync(ethWalletAddress);
            return Web3.Convert.FromWei(balance.Value);
        }

        public async Task<string> GetNetworkVersionAsync()
        {
            return await _web3.Net.Version.SendRequestAsync();
        }
    }
}
