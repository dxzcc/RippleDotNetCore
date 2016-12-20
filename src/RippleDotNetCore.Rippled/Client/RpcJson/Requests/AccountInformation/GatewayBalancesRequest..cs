using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class GatewayBalancesRequest : RpcJsonRequest<GatewayBalancesRequestParams>
    {
        public override string Method => ApiMethod.GatewayBalances;
    }
}
