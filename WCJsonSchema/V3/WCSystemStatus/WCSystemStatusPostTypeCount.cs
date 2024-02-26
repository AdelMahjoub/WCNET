using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusPostTypeCount
    {
        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("count")]
        public string? Count { get; set; }
    }
}
