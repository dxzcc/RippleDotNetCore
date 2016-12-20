using System.Threading.Tasks;
using RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger;
using RippleDotNetCore.Rippled.Interfaces;
using RippleDotNetCore.Rippled.Models.Responses.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests
{
    public class LedgerRequests : RequestBase
    {
        public LedgerRequests(IRippledClient client) : base(client) { }

        public async Task<RpcJsonResponse<LedgerResult>> LedgerAsync (LedgerRequest request)
        {
            return await PostAsync<RpcJsonResponse<LedgerResult>, LedgerResult>(request);
        }

        public async Task<RpcJsonResponse<LedgerClosedResult>> LedgerClosedAsync (LedgerClosedRequest request)
        {
            return await PostAsync<RpcJsonResponse<LedgerClosedResult>, LedgerClosedResult>(request);
        }

        public async Task<RpcJsonResponse<LedgerCurrentResult>> LedgerCurrentAsync (LedgerCurrentRequest request)
        {
            return await PostAsync<RpcJsonResponse<LedgerCurrentResult>, LedgerCurrentResult>(request);
        }

        public async Task<RpcJsonResponse<LedgerDataResult>> LedgerDataAsync (LedgerDataRequest request)
        {
            return await PostAsync<RpcJsonResponse<LedgerDataResult>, LedgerDataResult>(request);
        }

        public async Task<RpcJsonResponse<LedgerEntryResult>> LedgerEntryAsync (LedgerEntryRequest request)
        {
            return await PostAsync<RpcJsonResponse<LedgerEntryResult>, LedgerEntryResult>(request);
        }
    }
}
