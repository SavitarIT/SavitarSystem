using System.Threading.Tasks;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts
{
    public interface IEthereumService
    {
        Task<decimal> GetLatestBlockNumberAsync();
        Task<decimal> GetBalanceAsync(string ethWalletAddress = "0xde0b295669a9fd93d5f28d9ec85e40f4cb697bae");
        Task<string> GetNetworkVersionAsync();
    }
}
