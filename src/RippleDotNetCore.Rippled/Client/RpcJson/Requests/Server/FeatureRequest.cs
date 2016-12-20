using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class FeatureRequest : RpcJsonRequest<FeatureRequestParams>
    {
        public override string Method => ApiMethod.Feature;
    }
}
