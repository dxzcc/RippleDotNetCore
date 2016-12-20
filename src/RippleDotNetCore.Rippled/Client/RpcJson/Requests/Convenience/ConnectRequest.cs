using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Convenience;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Convenience
{
    public class ConnectRequest : RpcJsonRequest<ConnectRequestParams>
    {
        public override string Method => ApiMethod.Connect;
    }
}
