using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCShippingZones
{
    public class WCShippingZoneLocation : WCEntity
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }
    }
}
