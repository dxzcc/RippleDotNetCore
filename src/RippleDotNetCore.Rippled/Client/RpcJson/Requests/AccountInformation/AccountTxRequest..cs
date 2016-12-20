using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountTxRequest : RpcJsonRequest<AccountTxRequestParams>
    {
        public override string Method => ApiMethod.AccountTx;
    }
}
