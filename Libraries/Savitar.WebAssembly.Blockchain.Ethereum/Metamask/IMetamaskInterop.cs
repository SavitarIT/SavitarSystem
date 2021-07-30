using System.Threading.Tasks;
using Nethereum.JsonRpc.Client.RpcMessages;

namespace Savitar.WebAssembly.Blockchain.Ethereum.Metamask
{
    public interface IMetamaskInterop
    {
        ValueTask<string> EnableEthereumAsync();
        ValueTask<bool> CheckMetamaskAvailability();
        ValueTask<string> GetSelectedAddress();
        ValueTask<RpcResponseMessage> SendAsync(RpcRequestMessage rpcRequestMessage);
        ValueTask<RpcResponseMessage> SendTransactionAsync(MetamaskRpcRequestMessage rpcRequestMessage);
        ValueTask<string> SignAsync(string utf8Hex);
    }
}