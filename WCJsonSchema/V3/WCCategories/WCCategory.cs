using Newtonsoft.Json;
using WCNET.WCJsonSchema.V3.WCProducts;

namespace WCNET.WCJsonSchema.V3.WCCategories
{
    public class WCCategory : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("parent")]
        public int? Parent { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("display")]
        public string? Display { get; set; }

        [JsonProperty("menu_order")]
        public int? MenuOrder { get; set; }

        [JsonProperty("count")]
        public int? Count { get; set; }

        [JsonProperty("image")]
        public _ProductImage? Image { get; set; }
    }
}
