using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerCurrentRequest : RpcJsonRequest<LedgerCurrentRequestParams>
    {
        public override string Method => ApiMethod.LedgerCurrent;
    }
}
