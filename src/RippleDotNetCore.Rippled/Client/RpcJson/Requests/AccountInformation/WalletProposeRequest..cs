using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class WalletProposeRequest : RpcJsonRequest<WalletProposeRequestParams>
    {
        public override string Method => ApiMethod.WalletPropose;
    }
}
