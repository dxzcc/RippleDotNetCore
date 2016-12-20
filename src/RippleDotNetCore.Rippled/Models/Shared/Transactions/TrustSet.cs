using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared.Transactions
{
    public class TrustSet : TransactionBase
    {
        public IAmount LimitAmount { get; set; }
        public int? QualityIn { get; set; }
        public int? QualityOut { get; set; }
    }
}
