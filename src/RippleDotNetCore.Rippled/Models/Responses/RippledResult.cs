using RippleDotNetCore.Rippled.Enums;
using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Responses
{
    public class RippledResult : IRippledResult
    {
        public Status Status { get; set; }
        public Error? Error { get; set; }
        public int? ErrorCode { get; set; }
        public string ErrorMessage { get; set; }
    }
}
