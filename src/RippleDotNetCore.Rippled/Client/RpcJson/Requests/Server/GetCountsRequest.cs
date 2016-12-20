using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class GetCountsRequest : RpcJsonRequest<GetCountsRequestParams>
    {
        public override string Method => ApiMethod.GetCounts;
    }
}
