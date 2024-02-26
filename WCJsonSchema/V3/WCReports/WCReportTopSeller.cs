using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReports
{
    public class WCReportTopSeller : WCEntity
    {
        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("product_id")]
        public uint? ProductId { get; set; }

        [JsonProperty("quantity")]
        public uint? Quantity { get; set; }
    }
}
