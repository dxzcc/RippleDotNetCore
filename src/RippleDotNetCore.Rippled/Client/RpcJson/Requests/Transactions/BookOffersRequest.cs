using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Transactions;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Transactions
{
    public class BookOffersRequest : RpcJsonRequest<BookOffersRequestParams>
    {
        public override string Method => ApiMethod.BookOffers;
    }
}
