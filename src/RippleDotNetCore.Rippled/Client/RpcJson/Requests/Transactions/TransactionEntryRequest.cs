using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class TransactionEntryRequest : RpcJsonRequest<TransactionEntryRequestParams>
    {
        public override string Method => ApiMethod.TransactionEntry;
    }
}
