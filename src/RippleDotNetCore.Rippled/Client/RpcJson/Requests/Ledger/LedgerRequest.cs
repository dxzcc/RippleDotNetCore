using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerRequest : RpcJsonRequest<LedgerRequestParams>
    {
        public override string Method => ApiMethod.Ledger;
    }
}
