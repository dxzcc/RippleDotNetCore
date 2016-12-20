using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountOffersRequest : RpcJsonRequest<AccountOffersRequestParams>
    {
        public override string Method => ApiMethod.AccountOffers;
    }
}
