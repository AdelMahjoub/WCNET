using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusSecurity : WCEntity
    {
        [JsonProperty("secure_connection")]
        public bool? SecureConnection { get; set; }

        [JsonProperty("hide_errors")]
        public bool? HideErrors { get; set; }
    }
}
