using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusSetting : WCEntity
    {
        [JsonProperty("api_enabled")]
        public bool? ApiEnabled { get; set; }

        [JsonProperty("force_ssl")]
        public bool? ForceSsl { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("currency_symbol")]
        public string? CurrencySymbol { get; set; }

        [JsonProperty("currency_position")]
        public string? CurrencyPosition { get; set; }

        [JsonProperty("thousand_separator")]
        public string? ThousandSeparator { get; set; }

        [JsonProperty("decimal_separator")]
        public string? DecimalSeparator { get; set; }

        [JsonProperty("number_of_decimals")]
        public int? NumberOfDecimals { get; set; }

        [JsonProperty("geolocation_enabled")]
        public bool? GeolocationEnabled { get; set; }

        [JsonProperty("woocommerce_com_connected")]
        public string? WoocommerceComConnected { get; set; }

        [JsonProperty("enforce_approved_download_dirs")]
        public bool? EnforceApprovedDownloadDirs { get; set; }

        [JsonProperty("order_datastore")]
        public string? OrderDatastore { get; set; }

        [JsonProperty("HPOS_feature_screen_enabled")]
        public bool? HPOSFeatureScreenEnabled { get; set; }

        [JsonProperty("HPOS_enabled")]
        public bool? HPOSEnabled { get; set; }

        [JsonProperty("HPOS_sync_enabled")]
        public bool? HPOSSyncEnabled { get; set; }

        [JsonProperty("taxonomies")]
        public object? Taxonomies { get; set; }

        [JsonProperty("product_visibility_terms")]
        public object? ProductVisibilityTerms { get; set; }
    }
}
