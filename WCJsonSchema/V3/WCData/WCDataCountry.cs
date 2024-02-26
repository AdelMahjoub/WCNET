using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCData
{
    public class WCDataCountry : WCEntity
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("states")]
        public List<_WCDataCountryState>? States { get; set; }
    }

    public class _WCDataCountryState
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }
}
