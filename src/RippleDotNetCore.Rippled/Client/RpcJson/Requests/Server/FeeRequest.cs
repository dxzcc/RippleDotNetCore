﻿using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class FeeRequest : RpcJsonRequest<FeeRequestParams>
    {
        public override string Method => ApiMethod.Fee;
    }
}
