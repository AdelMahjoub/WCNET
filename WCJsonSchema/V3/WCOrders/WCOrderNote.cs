using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCOrders
{
    public class WCOrderNote : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("author")]
        public string? Author { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("note")]
        public string? Note { get; set; }

        [JsonProperty("customer_note")]
        public string? CustomerNote { get; set; }

        [JsonProperty("added_by_user")]
        public bool? AddedByUser { get; set; }

    }

}
