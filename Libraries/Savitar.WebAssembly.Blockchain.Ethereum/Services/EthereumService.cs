using Nethereum.Hex.HexTypes;
using Nethereum.RPC.Eth.DTOs;
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

        public async Task<HexBigInteger> GetLatestBlockNumber()
        {
            return await _web3.Eth.Blocks.GetBlockNumber.SendRequestAsync();
        }   

        public async Task<decimal> GetBalance()
        {            
            var balance = await _web3.Eth.GetBalance.SendRequestAsync("0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae");
            return Web3.Convert.FromWei(balance.Value);
        }

        public async Task<string> GetNetworkVersion()
        {
            return await _web3.Net.Version.SendRequestAsync();
        }
    }
}
