using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class TxRequest : RpcJsonRequest<TxRequestParams>
    {
        public override string Method => ApiMethod.Tx;
    }
}
