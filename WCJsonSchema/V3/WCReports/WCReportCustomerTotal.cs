using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReports
{
    public class WCReportCustomerTotal : WCEntity
    {
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("total")]
        public uint? Total { get; set; }
    }
}
