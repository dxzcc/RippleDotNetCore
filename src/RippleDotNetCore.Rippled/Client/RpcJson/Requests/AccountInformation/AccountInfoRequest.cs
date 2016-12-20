using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountInfoRequest : RpcJsonRequest<AccountInfoRequestParams>
    {
        public override string Method => ApiMethod.AccountInfo;
    }
}
