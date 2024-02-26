using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusPage
    {
        [JsonProperty("page_name")]
        public string? PageName { get; set; }

        [JsonProperty("page_id")]
        public string? PageId { get; set; }

        [JsonProperty("page_set")]
        public bool? PageSet { get; set; }

        [JsonProperty("page_exists")]
        public bool? PageExists { get; set; }

        [JsonProperty("page_visible")]
        public bool? PageVisible { get; set; }

        [JsonProperty("shortcode")]
        public string? Shortcode { get; set; }

        [JsonProperty("block")]
        public string? Block { get; set; }

        [JsonProperty("shortcode_required")]
        public bool? ShortcodeRequired { get; set; }

        [JsonProperty("shortcode_present")]
        public bool? ShortcodePresent { get; set; }

        [JsonProperty("block_present")]
        public bool? BlockPresent { get; set; }

        [JsonProperty("block_required")]
        public bool? BlockRequired { get; set; }
    }
}
