﻿using RippleDotNetCore.Rippled.Models.Shared.Transactions;

namespace RippleDotNetCore.Rippled.Models.Shared.AccountInformation
{
    public class Transaction
    {
        public Meta Meta { get; set; }
        public dynamic Tx { get; set; } // ToDo
        public bool Validated { get; set; }
    }
}
