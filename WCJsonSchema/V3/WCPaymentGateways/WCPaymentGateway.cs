using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCPaymentGateways
{
    public class WCPaymentGateway : WCEntity
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("method_title")]
        public string? MethodTitle { get; set; }

        [JsonProperty("method_description")]
        public string? MethodDescription { get; set; }

        [JsonProperty("method_supports")]
        public List<string>? MethodSupports { get; set; }

        [JsonProperty("settings")]
        public object? Settings { get; set; }

        [JsonProperty("needs_setup")]
        public bool? NeedsSetup { get; set; }

        [JsonProperty("post_install_scripts")]
        public List<object>? PostInstallScripts { get; set; }

        [JsonProperty("settings_url")]
        public string? SettingsUrl { get; set; }

        [JsonProperty("connection_url")]
        public object? ConnectionUrl { get; set; }

        [JsonProperty("setup_help_text")]
        public object? SetupHelpText { get; set; }

        [JsonProperty("required_settings_keys")]
        public List<object>? RequiredSettingsKeys { get; set; }
    }
}
