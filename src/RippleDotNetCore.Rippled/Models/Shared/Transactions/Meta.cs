using System.Collections.Generic;
using RippleDotNetCore.Rippled.Enums;

namespace RippleDotNetCore.Rippled.Models.Shared.Transactions
{
    public class Meta
    {
        public IEnumerable<dynamic> AffectedNodes { get; set; } 
        public string TransactionIndex { get; set; }
        public TesResult TransactionResult { get; set; }
    }
}
