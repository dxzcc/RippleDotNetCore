using RippleDotNetCore.Rippled.Models.Shared.Server;

namespace RippleDotNetCore.Rippled.Models.Responses.Server
{
    public class ConsensusInfoResult : RippledResult
    {
        public ConsensusInfo Info { get; set; } 
    }
}
