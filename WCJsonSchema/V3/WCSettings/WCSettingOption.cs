using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSettings
{
    public class WCSettingOption : WCEntity
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("label")]
        public string? Label { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("options")]
        public object? Options { get; set; }

        [JsonProperty("default")]
        public object? Default { get; set; }

        [JsonProperty("value")]
        public object? Value { get; set; }

        [JsonProperty("group_id")]
        public string? GroupId { get; set; }

        [JsonProperty("tip")]
        public string? Tip { get; set; }

    }
}
