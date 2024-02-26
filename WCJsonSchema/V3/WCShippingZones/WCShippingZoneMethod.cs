using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCShippingZones
{
    public class WCShippingZoneMethod: WCEntity
    {
        [JsonProperty("instance_id")]
        public uint? InstanceId { get; set; }

        [JsonProperty("title")]
        public string? Title { get; set; }

        [JsonProperty("order")]
        public int? Order { get; set; }

        [JsonProperty("enabled")]
        public bool? Enabled { get; set; }

        [JsonProperty("method_id")]
        public string? MethodId { get; set; }

        [JsonProperty("method_title")]
        public string? MethodTitle { get; set; }

        [JsonProperty("method_description")]
        public string? MethodDescription { get; set; }

        [JsonProperty("settings")]
        public _WCShippingMethodSetting? Settings { get; set; }
    }

    public class _WCShippingMethodSetting
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("value")]
        public string? Value { get; set; }

        [JsonProperty("default")]
        public string? Default { get; set; }

        [JsonProperty("tip")]
        public string? Tip { get; set; }

        [JsonProperty("placeholder")]
        public string? Placeholder { get; set; }
    }
}
