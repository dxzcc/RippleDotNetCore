using RippleDotNetCore.Rippled.Enums;

namespace RippleDotNetCore.Rippled.Interfaces
{
    public interface ITransaction : IDefaultResolver
    {
        TransactionNodeType TransactionType { get; set; }
    }
}
