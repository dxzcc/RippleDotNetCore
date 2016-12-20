using RippleDotNetCore.Rippled.Interfaces;

namespace RippleDotNetCore.Rippled.Models.Responses.Transactions
{
    public class SignResult : RippledResult
    {
        public string TxBlob { get; set; }
        public ITransaction TxJson { get; set; }
    }
}
