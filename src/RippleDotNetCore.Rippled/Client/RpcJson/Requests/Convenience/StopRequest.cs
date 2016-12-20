using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Convenience;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Convenience
{
    public class StopRequest : RpcJsonRequest<StopRequestParams>
    {
        public override string Method => ApiMethod.Stop;
    }
}
