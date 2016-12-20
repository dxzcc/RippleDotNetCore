using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class NorippleCheckRequest : RpcJsonRequest<NorippleCheckRequestParams>
    {
        public override string Method => ApiMethod.NoRippleCheck;
    }
}
