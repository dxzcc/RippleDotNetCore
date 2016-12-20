﻿using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class ServerStateRequest : RpcJsonRequest<ServerStateRequestParams>
    {
        public override string Method => ApiMethod.ServerState;
    }
}
