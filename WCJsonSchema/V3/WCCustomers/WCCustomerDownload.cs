using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCCustomers
{
    public class WCCustomerDownload : WCEntity
    {
        [JsonProperty("download_id")]
        public string? DownloadId { get; set; }

        [JsonProperty("download_url")]
        public string? DownloadUrl { get; set; }

        [JsonProperty("product_id")]
        public uint? ProductId { get; set; }

        [JsonProperty("product_name")]
        public string? ProductName { get; set; }

        [JsonProperty("download_name")]
        public string? DownloadName { get; set; }

        [JsonProperty("order_id")]
        public uint? OrderId { get; set; }

        [JsonProperty("order_key")]
        public string? OrderKey { get; set; }

        [JsonProperty("downloads_remaining")]
        public string? DownloadsRemaining { get; set; }

        [JsonProperty("access_expires")]
        public DateTime? AccessExpires { get; set; }

        [JsonProperty("access_expires_gmt")]
        public DateTime? AccessExpiresGmt { get; set; }

        [JsonProperty("file")]
        public _File? File { get; set; }

    }

    public class _File
    {
        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("file")]
        public string? FileUrl { get; set; }
    }
}
