using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class FetchInfoRequest : RpcJsonRequest<FetchInfoRequestParams>
    {
        public override string Method => ApiMethod.FetchInfo;
    }
}
