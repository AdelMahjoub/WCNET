using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReports
{
    public class WCReportSale : WCEntity
    {
        [JsonProperty("total_sales")]
        public string? TotalSales { get; set; }

        [JsonProperty("net_sales")]
        public string? NetSales { get; set; }

        [JsonProperty("average_sales")]
        public string? AverageSales { get; set; }

        [JsonProperty("total_orders")]
        public uint? TotalOrders { get; set; }

        [JsonProperty("total_items")]
        public uint? TotalItems { get; set; }

        [JsonProperty("total_tax")]
        public string? TotalTax { get; set; }

        [JsonProperty("total_shipping")]
        public string? TotalShipping { get; set; }

        [JsonProperty("total_refunds")]
        public uint? TotalRefunds { get; set; }

        [JsonProperty("total_discount")]
        public string? TotalDiscount { get; set; }

        [JsonProperty("totals_grouped_by")]
        public string? TotalsGroupedBy { get; set; }

        [JsonProperty("totals")]
        public object? Totals { get; set; }
    }
}
