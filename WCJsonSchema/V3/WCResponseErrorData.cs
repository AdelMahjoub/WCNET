using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3
{
    public class WCResponseErrorData
    {
        [JsonProperty("status")]
        public int? Status { get; set; }
    }
}
