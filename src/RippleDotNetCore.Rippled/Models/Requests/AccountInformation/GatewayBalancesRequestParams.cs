using System.Collections.Generic;

namespace RippleDotNetCore.Rippled.Models.Requests.AccountInformation
{
    public class GatewayBalancesRequestParams
    {
        public string Account { get; set; }
        public bool Strict { get; set; }
        public IEnumerable<string> HotWallet { get; set; }
        public string LedgerHash { get; set; }
        public string LedgerIndex { get; set; }
    }
}
