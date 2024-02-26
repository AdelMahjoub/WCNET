using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCData
{
    public class WCDataCurrency : WCEntity
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("symbol")]
        public string? Symbol { get; set; }
    }
}
