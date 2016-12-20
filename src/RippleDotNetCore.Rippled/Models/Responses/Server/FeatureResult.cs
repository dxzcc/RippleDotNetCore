using System.Collections.Generic;
using RippleDotNetCore.Rippled.Models.Shared.Server;

namespace RippleDotNetCore.Rippled.Models.Responses.Server
{
    public class FeatureResult : RippledResult
    {
        public Dictionary<string, Feature> Result { get; set; }
    }
}
