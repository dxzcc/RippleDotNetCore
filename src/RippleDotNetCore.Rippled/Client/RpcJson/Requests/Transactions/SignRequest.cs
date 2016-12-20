using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class SignRequest : RpcJsonRequest<SignRequestParams>
    {
        public override string Method => ApiMethod.Sign;
    }
}
