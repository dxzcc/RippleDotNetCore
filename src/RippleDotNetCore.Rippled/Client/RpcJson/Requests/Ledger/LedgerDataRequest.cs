using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerDataRequest : RpcJsonRequest<LedgerDataRequestParams>
    {
        public override string Method => ApiMethod.LedgerData;
    }
}
