using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Convenience;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Convenience
{
    public class RandomRequest : RpcJsonRequest<RandomRequestParams>
    {
        public override string Method => ApiMethod.Random;
    }
}
