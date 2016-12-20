using RippleDotNetCore.Rippled.Enums;

namespace RippleDotNetCore.Rippled.Interfaces
{
    public interface ILedgerNode : IDefaultResolver
    {
        LedgerEntryType LedgerEntryType { get; set; }
    }
}
