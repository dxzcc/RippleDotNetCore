using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class ConsensusInfoRequest : RpcJsonRequest<ConsensusInfoRequestParams>
    {
        public override string Method => ApiMethod.ConsensusInfo;
    }
}
