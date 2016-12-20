using System.Collections.Generic;
using RippleDotNetCore.Rippled.Interfaces;
using RippleDotNetCore.Rippled.Models.Shared;

namespace RippleDotNetCore.Rippled.Models.Responses.Transactions
{
    public class RipplePathFindResult : RippledResult
    {
        public List<Path> PathsComputed { get; set; }
        public IAmount SourceAmount { get; set; } 
    }
}
