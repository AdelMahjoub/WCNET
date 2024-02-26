using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCShippingMethods
{
    public class WCShippingMethod : WCEntity
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }
    }
}
