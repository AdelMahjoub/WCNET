using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCTaxRates
{
    public class WCTaxRate : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("country")]
        public string? Country { get; set; }

        [JsonProperty("state")]
        public string? State { get; set; }

        [JsonProperty("postcode")]
        public string? Postcode { get; set; }

        [JsonProperty("city")]
        public string? City { get; set; }

        [JsonProperty("postcodes")]
        public List<string?> Postcodes { get; set; }

        [JsonProperty("cities")]
        public List<string?> Cities { get; set; }

        [JsonProperty("rate")]
        public string? Rate { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("priority")]
        public int? Priority { get; set; }

        [JsonProperty("compound")]
        public bool? Compound { get; set; }

        [JsonProperty("shipping")]
        public bool? Shipping { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("class")]
        public string? Class { get; set; }
    }
}
