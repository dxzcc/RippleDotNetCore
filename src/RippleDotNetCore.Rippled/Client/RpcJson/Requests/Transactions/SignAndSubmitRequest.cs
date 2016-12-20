using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignAndSubmitRequest : RpcJsonRequest<SignAndSubmitRequestParams>
    {
        public override string Method => ApiMethod.Submit;
    }
}
