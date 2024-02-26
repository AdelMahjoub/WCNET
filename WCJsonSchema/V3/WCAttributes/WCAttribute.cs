using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCAttributes
{
    public class WCAttribute : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("order_by")]
        public string? OrderBy { get; set; }

        [JsonProperty("has_archives")]
        public bool? HasArchives { get; set; }
    }
}
