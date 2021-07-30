using Nethereum.Hex.HexTypes;
using System.Threading.Tasks;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts
{
    public interface IEthereumService
    {
        Task<HexBigInteger> GetLatestBlockNumber();
        Task<decimal> GetBalance();
        Task<string> GetNetworkVersion();
    }
}
