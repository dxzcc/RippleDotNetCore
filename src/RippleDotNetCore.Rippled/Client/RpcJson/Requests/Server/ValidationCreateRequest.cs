﻿using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class ValidationCreateRequest : RpcJsonRequest<ValidationCreateRequestParams>
    {
        public override string Method => ApiMethod.ValidationCreate;
    }
}
