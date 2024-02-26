using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCOrders
{
    public class WCOrderRefund : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("amount")]
        public string? Amount { get; set; }

        [JsonProperty("reason")]
        public string? Reason { get; set; }

        [JsonProperty("refunded_by")]
        public int? RefundedBy { get; set; }

        [JsonProperty("refunded_payment")]
        public bool? RefundedPayment { get; set; }

        [JsonProperty("tax_lines")]
        public List<_OrderTaxLine>? TaxLines { get; set; }

        [JsonProperty("fee_lines")]
        public List<_OrderFeeLine>? FeeLines { get; set; }

        [JsonProperty("line_items")]
        public List<_OrderLineItem>? LineItems { get; set; }

        [JsonProperty("shipping_lines")]
        public List<_OrderShippingLine>? ShippingLines { get; set; }
    }
}
