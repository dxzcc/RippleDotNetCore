using System.Collections.Generic;
using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Server
{
    public class Load
    {
        public List<IJobType> JobTypes { get; set; }
        public int Threads { get; set; }
    }
}
