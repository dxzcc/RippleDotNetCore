﻿using System.Collections.Generic;

namespace RippleDotNetCore.Rippled.Models.Shared.Transactions
{
    public class SignerListSet : TransactionBase
    {
        public int SignerQuorum { get; set; }
        public IEnumerable<SignerEntry> SignerEntries { get; set; }
    }
}
