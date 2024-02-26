using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCTags
{
    public class WCTag : WCEntity
    {

        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }
    }
}
