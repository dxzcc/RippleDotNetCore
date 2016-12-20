using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignForRequest : RpcJsonRequest<SignForRequestParams>
    {
        public override string Method => ApiMethod.SignFor;
    }
}
