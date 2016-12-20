using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.AccountInformation;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.AccountInformation
{
    public class AccountObjectsRequest : RpcJsonRequest<AccountObjectsRequestParams>
    {
        public override string Method => ApiMethod.AccountObjects;
    }
}
