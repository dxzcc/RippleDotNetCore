namespace RippleDotNetCore.Rippled.Client.RpcJson
{
    public class RpcJsonResponse<T> : IRpcJsonResponse<T>
    {
        public T Result { get; set; }
    }
}
