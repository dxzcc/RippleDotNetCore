namespace RippleDotNetCore.Rippled.Models.Shared.Transactions
{
    public class OfferCancel : TransactionBase
    {
        public int? OfferSequence { get; set; }
    }
}
