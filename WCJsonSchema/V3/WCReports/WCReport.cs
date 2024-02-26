using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReports
{
    public class WCReport : WCEntity
    {
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
