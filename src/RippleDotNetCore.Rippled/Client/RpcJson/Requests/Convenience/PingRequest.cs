using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Convenience;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Convenience
{
    public class PingRequest : RpcJsonRequest<PingRequestParams>
    {
        public override string Method => ApiMethod.Ping;
    }
}
