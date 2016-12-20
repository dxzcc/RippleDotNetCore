using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerEntryRequest : RpcJsonRequest<LedgerEntryRequestParams>
    {
        public override string Method => ApiMethod.LedgerEntry;
    }
}
