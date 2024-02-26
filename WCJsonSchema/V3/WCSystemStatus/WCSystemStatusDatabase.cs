using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusDatabase : WCEntity
    {
        [JsonProperty("wc_database_version")]
        public string? WcDatabaseVersion { get; set; }

        [JsonProperty("database_prefix")]
        public string? DatabasePrefix { get; set; }

        [JsonProperty("maxmind_geoip_database")]
        public string? MaxmindGeoipDatabase { get; set; }

        [JsonProperty("database_tables")]
        public _WCSystemStatusDatabaseTables? DatabaseTables { get; set; }
    }

    public class _WCSystemStatusDatabaseTables
    {
        [JsonProperty("woocommerce")]
        public _WCSystemStatusDatabaseWoocommerce? Woocommerce { get; set; }
        [JsonProperty("other")]
        public object? Other { get; set; }
    }

    public class _WCSystemStatusDatabaseWoocommerce
    {
        [JsonProperty("wpet_woocommerce_sessions")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceSessions { get; set; }

        [JsonProperty("wpet_woocommerce_api_keys")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceApiKeys { get; set; }

        [JsonProperty("wpet_woocommerce_attribute_taxonomies")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceAttributeTaxonomies { get; set; }

        [JsonProperty("wpet_woocommerce_downloadable_product_permissions")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceDownloadableProductPermissions { get; set; }

        [JsonProperty("wpet_woocommerce_order_items")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceOrderItems { get; set; }

        [JsonProperty("wpet_woocommerce_order_itemmeta")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceOrderItemmeta { get; set; }

        [JsonProperty("wpet_woocommerce_tax_rates")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceTaxRates { get; set; }

        [JsonProperty("wpet_woocommerce_tax_rate_locations")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceTaxRateLocations { get; set; }

        [JsonProperty("wpet_woocommerce_shipping_zones")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceShippingZones { get; set; }

        [JsonProperty("wpet_woocommerce_shipping_zone_locations")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceShippingZoneLocations { get; set; }

        [JsonProperty("wpet_woocommerce_shipping_zone_methods")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceShippingZoneMethods { get; set; }

        [JsonProperty("wpet_woocommerce_payment_tokens")]
        public _WCSystemStatusDatabaseTable? WpetWoocommercePaymentTokens { get; set; }

        [JsonProperty("wpet_woocommerce_payment_tokenmeta")]
        public _WCSystemStatusDatabaseTable? WpetWoocommercePaymentTokenmeta { get; set; }

        [JsonProperty("wpet_woocommerce_log")]
        public _WCSystemStatusDatabaseTable? WpetWoocommerceLog { get; set; }
    }

    public class _WCSystemStatusDatabaseTable
    {
        [JsonProperty("data")]
        public string? Data { get; set; }

        [JsonProperty("index")]
        public string? Index { get; set; }

        [JsonProperty("engine")]
        public string? Engine { get; set; }
    }
}
