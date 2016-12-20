using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountLinesRequest : RpcJsonRequest<AccountLinesRequestParams>
    {
        public override string Method => ApiMethod.AccountLines;
    }
}
