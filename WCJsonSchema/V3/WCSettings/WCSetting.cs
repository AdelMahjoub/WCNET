using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSettings
{
    public class WCSetting: WCEntity
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("parent_id")]
        public string? ParentId { get; set; }

        [JsonProperty("sub_groups")]
        public List<object>? SubGroups { get; set; }
    }
}
