using System.Threading.Tasks;
using RippleDotNetCore.Rippled.Client.RpcJson.Requests;

namespace RippleDotNetCore.Rippled.Interfaces
{
    public interface IRippledClient
    {
        AccountInformationRequests AccountInformation { get; }
        ConvenienceRequests Convenience { get; }
        LedgerRequests Ledger { get; }
        ServerRequests Server { get; }
        TransactionRequests Transactions { get; }

        Task<bool> ConnectedAsync();
        Task<string> PostAsync(IRippledRequest request);
        string RippledApiVersion { get; }
    }
}
