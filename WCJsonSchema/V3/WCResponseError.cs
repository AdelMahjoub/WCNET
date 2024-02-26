using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3
{
    public class WCResponseError
    {
        [JsonProperty("code")]
        public string? Code { get; set; }

        [JsonProperty("message")]
        public string? Message { get; set; }

        [JsonProperty("data")]
        public WCResponseErrorData? Data { get; set; }
    }
}
