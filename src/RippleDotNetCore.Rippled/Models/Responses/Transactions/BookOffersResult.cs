using System.Collections.Generic;
using RippleDotNetCore.Rippled.Models.Shared.Transactions;

namespace RippleDotNetCore.Rippled.Models.Responses.Transactions
{
    public class BookOffersResult
    {
        public int? LedgerCurrentIndex { get; set; }
        public int? LedgerIndex { get; set; }
        public string LedgerHash { get; set; }
        public List<BookOffer> Offers { get; set; }
    }
}
