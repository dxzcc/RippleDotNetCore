using RippleDotNetCore.Rippled.Enums;

namespace RippleDotNetCore.Rippled.Interfaces
{
    public interface IRippledResult
    {
        Status Status { get; set; }
        Error? Error { get; set; }
    }
}
