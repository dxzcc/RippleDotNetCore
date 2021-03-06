﻿using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Server
{
    public class JobTypePerSecond : IJobType
    {
        public string JobType { get; set; }
        public int PerSecond { get; set; }
    }
}
