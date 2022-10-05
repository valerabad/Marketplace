using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marketplace.Common
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum MarketStatus
    {
        None = 1, 
        Canceled, 
        Finished, 
        Active,
    }
}