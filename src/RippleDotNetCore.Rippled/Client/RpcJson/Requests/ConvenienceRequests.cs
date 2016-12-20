using System.Threading.Tasks;
using RippleDotNetCore.Rippled.Client.RpcJson.Requests.Convenience;
using RippleDotNetCore.Rippled.Interfaces;
using RippleDotNetCore.Rippled.Models.Responses.Convenience;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests
{
    public class ConvenienceRequests : RequestBase
    {
        public ConvenienceRequests(IRippledClient client) : base(client) { }

        public async Task<RpcJsonResponse<ConnectResult>> ConnectAsync(ConnectRequest request)
        {
            return await PostAsync<RpcJsonResponse<ConnectResult>, ConnectResult>(request);
        }

        public async Task<RpcJsonResponse<PingResult>> PingAsync(PingRequest request)
        {
            return await PostAsync<RpcJsonResponse<PingResult>, PingResult>(request);
        }

        public async Task<RpcJsonResponse<RandomResult>> RandomAsync(RandomRequest request)
        {
            return await PostAsync<RpcJsonResponse<RandomResult>, RandomResult>(request);
        }

        public async Task<RpcJsonResponse<StopResult>> StopAsync(StopRequest request)
        {
            return await PostAsync<RpcJsonResponse<StopResult>, StopResult>(request);
        }
    }
}
