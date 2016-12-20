using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class RipplePathFindRequest : RpcJsonRequest<RipplePathFindRequestParams>
    {
        public override string Method => ApiMethod.RipplePathFind;
    }
}
