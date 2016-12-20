using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Server
{
    public class JobTypeInProgress : IJobType
    {
        public string JobType { get; set; }
        public int InProgress { get; set; }
    }
}
