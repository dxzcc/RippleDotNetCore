using RippleDotNetCore.Rippled.Enums;

namespace RippleDotNetCore.Rippled.Models.Shared.Ledger
{
    public class LedgerState
    {
        public string Data { get; set; }
        public LedgerEntryType LedgerEntryType { get; set; }
        public string Index { get; set; }
    }
}
