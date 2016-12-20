using RippleDotNetCore.Rippled.Constants;
using RippleDotNetCore.Rippled.Models.Requests.Server;

namespace RippleDotNetCore.Rippled.Client.RpcJson.Requests.Server
{
    public class CanDeleteRequest : RpcJsonRequest<CanDeleteRequestParams>
    {
        public override string Method => ApiMethod.CanDelete;
    }
}
