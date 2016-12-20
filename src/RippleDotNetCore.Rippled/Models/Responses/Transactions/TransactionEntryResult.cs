using RippleDotNetCore.Rippled.Interfaces;
using RippleDotNetCore.Rippled.Models.Shared.Transactions;

namespace RippleDotNetCore.Rippled.Models.Responses.Transactions
{
    public class TransactionEntryResult : RippledResult
    {
        public string LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public Meta Metadata { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
