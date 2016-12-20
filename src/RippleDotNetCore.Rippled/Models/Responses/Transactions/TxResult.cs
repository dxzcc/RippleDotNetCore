using System.Collections.Generic;
using RippleDotNetCore.Rippled.Models.Shared.Transactions;
using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Responses.Transactions
{
    public class TxResult
    {
        public string LedgerIndex { get; set; }
        public string Hash { get; set; }
        public IEnumerable<Meta> Meta { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
