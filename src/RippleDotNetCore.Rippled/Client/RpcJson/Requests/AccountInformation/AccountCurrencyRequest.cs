using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountCurrencyRequest : RpcJsonRequest<AccountCurrencyRequestParams>
    {
        public override string Method => ApiMethod.AccountCurrencies;
    }
}
