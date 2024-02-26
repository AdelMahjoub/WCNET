using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCCoupons
{
    public class WCCoupon : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("discount_type")]
        public string? DiscountType { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("date_expires")]
        public DateTime? DateExpires { get; set; }

        [JsonProperty("date_expires_gmt")]
        public DateTime? DateExpiresGmt { get; set; }

        [JsonProperty("usage_count")]
        public uint? UsageCount { get; set; }

        [JsonProperty("individual_use")]
        public bool? IndividualUse { get; set; }

        [JsonProperty("product_ids")]
        public List<uint?>? ProductIds { get; set; }

        [JsonProperty("excluded_product_ids")]
        public List<uint?>? ExcludedProductIds { get; set; }

        [JsonProperty("usage_limit")]
        public int? UsageLimit { get; set; }

        [JsonProperty("usage_limit_per_user")]
        public uint? UsageLimitPerUser { get; set; }

        [JsonProperty("limit_usage_to_x_items")]
        public uint? LimitUsageToXItems { get; set; }

        [JsonProperty("free_shipping")]
        public bool? FreeShipping { get; set; }

        [JsonProperty("product_categories")]
        public List<uint?>? ProductCategories { get; set; }

        [JsonProperty("excluded_product_categories")]
        public List<uint?>? ExcludedProductCategories { get; set; }

        [JsonProperty("exclude_sale_items")]
        public bool? ExcludeSaleItems { get; set; }

        [JsonProperty("minimum_amount")]
        public string? MinimumAmount { get; set; }

        [JsonProperty("maximum_amount")]
        public string? MaximumAmount { get; set; }

        [JsonProperty("email_restrictions")]
        public List<string?>? EmailRestrictions { get; set; }

        [JsonProperty("used_by")]
        public List<uint?>? UsedBy { get; set; }
    }
}
