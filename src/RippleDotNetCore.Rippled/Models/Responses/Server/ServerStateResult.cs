using RippleDotNetCore.Rippled.Models.Shared.Server;

namespace RippleDotNetCore.Rippled.Models.Responses.Server
{
    public class ServerStateResult : RippledResult
    {
        public State State { get; set; }
    }
}
