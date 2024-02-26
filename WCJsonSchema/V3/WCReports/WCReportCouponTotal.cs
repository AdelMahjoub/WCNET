using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReports
{
    public class WCReportCouponTotal : WCEntity
    {
        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("total")]
        public uint? Total { get; set; }
    }
}
