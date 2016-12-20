using System.Collections.Generic;
using RippleDotNetCore.Rippled.Enums;
using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.LedgerNode
{
    public class DirectoryNode : ILedgerNode
    {
        public LedgerEntryType LedgerEntryType { get; set; }
        public int Flags { get; set; }
        public string RootIndex { get; set; } // ToDo: Check type
        public IEnumerable<string> Indexes { get; set; } // ToDo: Check type
        public int? IndexNext { get; set; }
        public int? IndexPrevious { get; set; }
        public string Owner { get; set; }
        public string TakerPaysCurrency { get; set; }
        public string TakerPaysIssuer { get; set; }
        public string TakerGetsCurrency { get; set; }
        public string TakerGetsIssuer { get; set; }
    }
}
