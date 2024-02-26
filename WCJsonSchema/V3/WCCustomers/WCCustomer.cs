using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCCustomers
{
    public class WCCustomer : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }

        [JsonProperty("first_name")]
        public string? FirstName { get; set; }

        [JsonProperty("last_name")]
        public string? LastName { get; set; }

        [JsonProperty("role")]
        public string? Role { get; set; }

        [JsonProperty("username")]
        public string? Username { get; set; }

        [JsonProperty("billing")]
        public _CustomerBilling? Billing { get; set; }

        [JsonProperty("shipping")]
        public _CustomerShipping? Shipping { get; set; }

        [JsonProperty("is_paying_customer")]
        public bool? IsPayingCustomer { get; set; }

        [JsonProperty("avatar_url")]
        public string? AvatarUrl { get; set; }

    }

    public class _CustomerBilling
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

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("email")]
        public string? Email { get; set; }
    }

    public class _CustomerShipping
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

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("phone")]
        public string? Phone { get; set; }
    }
}
