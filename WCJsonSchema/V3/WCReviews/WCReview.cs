using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCReviews
{
    public class WCReview : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("product_id")]
        public uint? ProductId { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("reviewer")]
        public string? Reviewer { get; set; }

        [JsonProperty("reviewer_email")]
        public string? ReviewerEmail { get; set; }

        [JsonProperty("review")]
        public string? Review { get; set; }

        [JsonProperty("rating")]
        public uint? Rating { get; set; }

        [JsonProperty("verified")]
        public bool? Verified { get; set; }
    }
}
