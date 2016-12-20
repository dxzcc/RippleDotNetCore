namespace RippleDotNetCore.Rippled.Client.RpcJson
{
    public interface IRpcJsonResponse<T>
    {
        T Result { get; set; }
    }
}
