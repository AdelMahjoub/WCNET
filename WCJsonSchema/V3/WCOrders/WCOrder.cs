using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCOrders
{
    public class WCOrder : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("parent_id")]
        public uint? ParentId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("currency")]
        public string? Currency { get; set; }

        [JsonProperty("version")]
        public string? Version { get; set; }

        [JsonProperty("prices_include_tax")]
        public bool? PricesIncludeTax { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("discount_total")]
        public string? DiscountTotal { get; set; }

        [JsonProperty("discount_tax")]
        public string? DiscountTax { get; set; }

        [JsonProperty("shipping_total")]
        public string? ShippingTotal { get; set; }

        [JsonProperty("shipping_tax")]
        public string? ShippingTax { get; set; }

        [JsonProperty("cart_tax")]
        public string? CartTax { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("customer_id")]
        public uint? CustomerId { get; set; }

        [JsonProperty("order_key")]
        public string? OrderKey { get; set; }

        [JsonProperty("billing")]
        public _OrderBilling? Billing { get; set; }

        [JsonProperty("shipping")]
        public _OrderShipping? Shipping { get; set; }

        [JsonProperty("payment_method")]
        public string? PaymentMethod { get; set; }

        [JsonProperty("payment_method_title")]
        public string? PaymentMethodTitle { get; set; }

        [JsonProperty("transaction_id")]
        public string? TransactionId { get; set; }

        [JsonProperty("customer_ip_address")]
        public string? CustomerIpAddress { get; set; }

        [JsonProperty("customer_user_agent")]
        public string? CustomerUserAgent { get; set; }

        [JsonProperty("created_via")]
        public string? CreatedVia { get; set; }

        [JsonProperty("customer_note")]
        public string? CustomerNote { get; set; }

        [JsonProperty("date_completed")]
        public DateTime? DateCompleted { get; set; }

        [JsonProperty("date_paid")]
        public DateTime? DatePaid { get; set; }

        [JsonProperty("cart_hash")]
        public string? CartHash { get; set; }

        [JsonProperty("number")]
        public string? Number { get; set; }

        [JsonProperty("line_items")]
        public List<_OrderLineItem>? LineItems { get; set; }

        [JsonProperty("tax_lines")]
        public List<_OrderTaxLine>? TaxLines { get; set; }

        [JsonProperty("shipping_lines")]
        public List<_OrderShippingLine>? ShippingLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<_OrderFeeLine>? FeeLines { get; set; }

        [JsonProperty("coupon_lines")]
        public List<_OrderCouponLine>? CouponLines { get; set; }

        [JsonProperty("refunds")]
        public List<_OrderRefund>? Refunds { get; set; }

        [JsonProperty("payment_url")]
        public string? PaymentUrl { get; set; }

        [JsonProperty("is_editable")]
        public bool? IsEditable { get; set; }

        [JsonProperty("needs_payment")]
        public bool? NeedsPayment { get; set; }

        [JsonProperty("needs_processing")]
        public bool? NeedsProcessing { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("date_completed_gmt")]
        public DateTime? DateCompletedGmt { get; set; }

        [JsonProperty("date_paid_gmt")]
        public DateTime? DatePaidGmt { get; set; }

        [JsonProperty("currency_symbol")]
        public string? CurrencySymbol { get; set; }
    }

    public class _OrderBilling
    {
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("address_1")]
        public string? Address1 { get; set; }

        [JsonProperty("address_2")]
        public string? Address2 { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }

    public class _OrderShipping
    {
        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("company")]
        public string? Company { get; set; }

        [JsonProperty("address_1")]
        public string? Address1 { get; set; }

        [JsonProperty("address_2")]
        public string? Address2 { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }

    public class _OrderLineItem
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("product_id")]
        public uint? ProductId { get; set; }

        [JsonProperty("variation_id")]
        public uint? VariationId { get; set; }

        [JsonProperty("quantity")]
        public int? Quantity { get; set; }

        [JsonProperty("tax_class")]
        public string? TaxClass { get; set; }

        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }

        [JsonProperty("subtotal_tax")]
        public string? SubtotalTax { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("taxes")]
        public List<_OrderLineItemTaxis>? Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<EntityMetaData>? MetaData { get; set; }

        [JsonProperty("sku")]
        public string? Sku { get; set; }

        [JsonProperty("price")]
        public double? Price { get; set; }

        [JsonProperty("image")]
        public _OrderLineItemImage? Image { get; set; }

        [JsonProperty("parent_name")]
        public object? ParentName { get; set; }
    }

    public class _OrderShippingLine
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("method_title")]
        public string? MethodTitle { get; set; }

        [JsonProperty("method_id")]
        public string? MethodId { get; set; }

        [JsonProperty("instance_id")]
        public string? InstanceId { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("taxes")]
        public List<_OrderShippingLineTaxis>? Taxes { get; set; }

        [JsonProperty("meta_data")]
        public List<EntityMetaData>? MetaData { get; set; }
    }

    public class _OrderLineItemImage
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("src")]
        public string? Src { get; set; }
    }

    public class _OrderTaxLine
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("rate_code")]
        public string? RateCode { get; set; }

        [JsonProperty("rate_id")]
        public int? RateId { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("compound")]
        public bool? Compound { get; set; }

        [JsonProperty("tax_total")]
        public string? TaxTotal { get; set; }

        [JsonProperty("shipping_tax_total")]
        public string? ShippingTaxTotal { get; set; }

        [JsonProperty("rate_percent")]
        public double? RatePercent { get; set; }

        [JsonProperty("meta_data")]
        public List<EntityMetaData>? MetaData { get; set; }
    }

    public class _OrderLineItemTaxis
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("subtotal")]
        public string? Subtotal { get; set; }
    }

    public class _OrderShippingLineTaxis : _OrderLineItemTaxis { }

    public class _OrderFeeLine
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("tax_class")]
        public string? TaxClass { get; set; }

        [JsonProperty("taxt_status")]
        public string? TaxStatus { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("taxes")]
        public List<_OrderTaxLine>? Taxes { get; set; }

        [JsonProperty("meta_data")]
        public EntityMetaData? MetaData { get; set; }
    }

    public class _OrderCouponLine
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("discount")]
        public string? Discount { get; set; }

        [JsonProperty("discount_tax")]
        public string? DiscountTax { get; set; }

        [JsonProperty("meta_data")]
        public EntityMetaData? MetaData { get; set; }
    }

    public class _OrderRefund
    {
        [JsonProperty("id")]
        public uint? Id { set; get; }

        [JsonProperty("reason")]
        public string? Reason { get; set; }

        [JsonProperty("total")]
        public string? Total { get; set; }
    }
}