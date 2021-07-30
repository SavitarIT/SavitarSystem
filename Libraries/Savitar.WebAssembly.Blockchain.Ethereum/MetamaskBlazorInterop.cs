using System.Threading.Tasks;
using Microsoft.JSInterop;
using Nethereum.JsonRpc.Client.RpcMessages;
using Newtonsoft.Json;
using Savitar.WebAssembly.Blockchain.Ethereum.Metamask;

namespace Savitar.WebAssembly.Blockchain.Ethereum
{
    public class MetamaskBlazorInterop : IMetamaskInterop
    {
        private readonly IJSRuntime _jsRuntime;

        public MetamaskBlazorInterop(IJSRuntime jsRuntime)
        {
            _jsRuntime = jsRuntime;
        }

        public async ValueTask<string> EnableEthereumAsync()
        {
            return await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.EnableEthereum");
        }

        public async ValueTask<bool> CheckMetamaskAvailability()
        {
            return await _jsRuntime.InvokeAsync<bool>("NethereumMetamaskInterop.IsMetamaskAvailable");
        }

        public async ValueTask<RpcResponseMessage> SendAsync(RpcRequestMessage rpcRequestMessage)
        {
            var response = await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Request", JsonConvert.SerializeObject(rpcRequestMessage));
            return JsonConvert.DeserializeObject<RpcResponseMessage>(response);
        }

        public async ValueTask<RpcResponseMessage> SendTransactionAsync(MetamaskRpcRequestMessage rpcRequestMessage)
        {
            var response = await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Request", JsonConvert.SerializeObject(rpcRequestMessage));
            return JsonConvert.DeserializeObject<RpcResponseMessage>(response);
        }

        public async ValueTask<string> SignAsync(string utf8Hex)
        {
            var result = await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.Sign", utf8Hex);
            return result.Trim('"');
        }

        public async ValueTask<string> GetSelectedAddress()
        {
            return await _jsRuntime.InvokeAsync<string>("NethereumMetamaskInterop.GetSelectedAddress");
        }


        [JSInvokable()]
        public static async Task MetamaskAvailableChanged(bool available)
        {
            await Ethereum.Metamask.MetamaskHostProvider.Current.ChangeMetamaskAvailableAsync(available);
        }

        [JSInvokable()]
        public static async Task SelectedAccountChanged(string selectedAccount)
        {
            await Ethereum.Metamask.MetamaskHostProvider.Current.ChangeSelectedAccountAsync(selectedAccount);
        }
    }
}