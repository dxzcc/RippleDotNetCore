using RippleDotNetCore.Rippled.Models.Shared.Server;

namespace RippleDotNetCore.Rippled.Models.Responses.Server
{
    public class ServerInfoResult : RippledResult
    {
        public ServerInfo Info { get; set; }
    }
}
