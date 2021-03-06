﻿using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Ledger;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Ledger
{
    public class LedgerClosedRequest : RpcJsonRequest<LedgerClosedRequestParams>
    {
        public override string Method => ApiMethod.LedgerClosed;
    }
}
