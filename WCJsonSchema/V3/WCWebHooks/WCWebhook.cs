using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCWebHooks
{
    public class WCWebhook : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("topic")]
        public string? Topic { get; set; }

        [JsonProperty("resource")]
        public string? Resource { get; set; }

        [JsonProperty("event")]
        public string? Event { get; set; }

        [JsonProperty("hooks")]
        public List<string>? Hooks { get; set; }

        [JsonProperty("delivery_url")]
        public string? DeliveryUrl { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }
    }
}
