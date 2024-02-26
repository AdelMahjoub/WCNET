using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCData
{
    public class WCDataContinent : WCEntity
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("countries")]
        public List<_WCDataContinentCountry>? Countries { get; set; }
    }

    public class _WCDataContinentCountry
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("currency_code")]
        public string? CurrencyCode { get; set; }

        [JsonProperty("currency_pos")]
        public string? CurrencyPos { get; set; }

        [JsonProperty("decimal_sep")]
        public string? DecimalSep { get; set; }

        [JsonProperty("dimension_unit")]
        public string? DimensionUnit { get; set; }

        [JsonProperty("num_decimals")]
        public int? NumDecimals { get; set; }

        [JsonProperty("thousand_sep")]
        public string? ThousandSep { get; set; }

        [JsonProperty("weight_unit")]
        public string? WeightUnit { get; set; }

        [JsonProperty("states")]
        public List<_WCDataContinentState>? States { get; set; }
    }

    public class _WCDataContinentState
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }
    }


}
