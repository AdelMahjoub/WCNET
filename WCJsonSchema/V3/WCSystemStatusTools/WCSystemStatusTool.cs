using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatusTools
{
    public class WCSystemStatusTool : WCEntity
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("action")]
        public string? Action { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
