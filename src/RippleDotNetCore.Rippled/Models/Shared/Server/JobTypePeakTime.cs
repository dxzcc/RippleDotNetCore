using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Server
{
    public class JobTypePeakTime : IJobType
    {
        public string JobType { get; set; }
        public int PeakTime { get; set; }
    }
}
