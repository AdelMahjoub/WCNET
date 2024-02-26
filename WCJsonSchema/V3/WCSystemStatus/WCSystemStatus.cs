using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatus : WCEntity
    {
        [JsonProperty("environment")]
        public WCSystemStatusEnv? Environment { get; set; }

        [JsonProperty("database")]
        public WCSystemStatusDatabase? Database { get; set; }

        [JsonProperty("active_plugins")]
        public List<WCSystemStatusPlugin>? ActivePlugins { get; set; }

        [JsonProperty("inactive_plugins")]
        public List<WCSystemStatusPlugin>? InactivePlugins { get; set; }

        [JsonProperty("dropins_mu_plugins")]
        public WCSystemStatusDropinsMuPlugin? DropinsMuPlugin { get; set; }

        [JsonProperty("theme")]
        public WCSystemStatusTheme? Theme { get; set; }

        [JsonProperty("settings")]
        public WCSystemStatusSetting? Settings { get; set; }

        [JsonProperty("security")]
        public WCSystemStatusSecurity? Security { get; set; }

        [JsonProperty("pages")]
        public List<WCSystemStatusPage>? Pages { get; set; }

        [JsonProperty("post_type_counts")]
        public List<WCSystemStatusPostTypeCount>? PostTtypeCounts { get; set; }
    }
}
