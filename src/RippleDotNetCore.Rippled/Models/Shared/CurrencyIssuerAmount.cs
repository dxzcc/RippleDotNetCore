using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Shared
{
    public class CurrencyIssuerAmount : IAmount
    {
        public string Currency { get; set; }
        public string Issuer { get; set; }
        public float Amount { get; set; }
    }
}
