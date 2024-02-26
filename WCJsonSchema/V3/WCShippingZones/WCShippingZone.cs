using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCShippingZones
{
    public class WCShippingZone : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }
    }
}
