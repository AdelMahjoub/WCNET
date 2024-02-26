using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCData
{
    public class WCData: WCEntity
    {
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
