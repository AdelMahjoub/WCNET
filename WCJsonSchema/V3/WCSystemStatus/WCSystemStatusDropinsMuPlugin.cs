using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCSystemStatus
{
    public class WCSystemStatusDropinsMuPlugin : WCEntity
    {
        [JsonProperty("dropins")]
        public List<WCSystemStatusPlugin>? Dropins { get; set; }

        [JsonProperty("mu_plugins")]
        public List<WCSystemStatusPlugin>? MuPlugins { get; set; }
    }
}
