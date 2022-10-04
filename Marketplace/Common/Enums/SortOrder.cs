using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Marketplace.Common;

[JsonConverter(typeof(StringEnumConverter))]
public enum SortOrder
{
    Asc = 0,    
    Desc,
}