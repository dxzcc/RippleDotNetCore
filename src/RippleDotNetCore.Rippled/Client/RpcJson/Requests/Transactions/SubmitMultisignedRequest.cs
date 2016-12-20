using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SubmitMultisignedRequest : RpcJsonRequest<SubmitMultisignedRequestParams>
    {
        public override string Method => ApiMethod.SubmitMultisigned;
    }
}
