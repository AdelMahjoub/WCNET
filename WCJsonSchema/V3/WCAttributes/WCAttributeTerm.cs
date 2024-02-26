using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCAttributes
{
    public class WCAttributeTerm : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("menu_order")]
        public int? MenuOrder { get; set; }

        [JsonProperty("count")]
        public uint? Count { get; set; }
    }
}
