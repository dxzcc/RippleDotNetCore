using System.Collections.Generic;
using RippleDotNetCore.Rippled.Models.Shared.Ledger;

namespace RippleDotNetCore.Rippled.Models.Responses.Ledger
{
    public class LedgerDataResult : RippledResult
    {
        public int LedgerIndex { get; set; }
        public int LedgerCurrentIndex { get; set; }
        public string LedgerHash { get; set; }
        public IEnumerable<LedgerState> State { get; set; }
        public string Marker { get; set; }
        public bool Validated { get; set; }
    }
}
