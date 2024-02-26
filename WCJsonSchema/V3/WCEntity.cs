using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3
{
    public class WCEntity
    {
        [JsonProperty("_links")]
        public EntityLinks? Links { get; set; }

        [JsonProperty("meta_data")]
        public List<EntityMetaData>? MetaData { get; set; }
    }

    public class EntityMetaData
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("key")]
        public string? Key { get; set; }

        [JsonProperty("value")]
        public object? Value { get; set; }

        [JsonProperty("display_key")]
        public string? DisplayKey { get; set; }

        [JsonProperty("display_value")]
        public string? DisplayValue { get; set; }
    }


    public class EntityLinks
    {
        [JsonProperty("self")]
        public List<EntityLinksSelf>? Self { get; set; }

        [JsonProperty("collection")]
        public List<EntityLinksCollection>? Collection { get; set; }

        [JsonProperty("customer")]
        public List<EntityLinksCustomer>? Customer { get; set; }
        [JsonProperty("up")]
        public List<EntityLinksCollection>? Up { get; set; }

        [JsonProperty("about")]
        public List<EntityLinksAbout>? About { get; set; }

        [JsonProperty("product")]
        public List<EntityLinksProduct>? Product { get; set; }
    }

    public class EntityLinksCollection
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class EntityLinksSelf
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class EntityLinksUp
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class EntityLinksCustomer
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class EntityLinksAbout
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }

    public class EntityLinksProduct
    {
        [JsonProperty("href")]
        public string? Href { get; set; }
    }
}
