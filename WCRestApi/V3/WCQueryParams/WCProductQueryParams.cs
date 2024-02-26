namespace WCNET.WCRestApi.V3.WCQueryParams

{
    public class WCProductQueryParams : WCEntityQueryParams
    {
        public List<uint>? parent;
        public List<uint>? parent_exclude;
        public string? slug;
        public string? status = WCProductStatus.publish.ToString();
        public string? type;
        public string? sku;
        public bool? featured;
        public List<uint>? category;
        public List<uint>? tag;
        public List<uint>? shipping_class;
        public string? attribute;
        public uint? attribute_term;
        public string? tax_class;
        public string? on_sale;
        public string? min_price;
        public string? max_price;
        public string? stock_status;
    }

    public enum WCProductStatus
    {
        any,
        draft,
        pending,
        publish,
        _private
    }

    public enum WCProductType
    {
        simple,
        grouped,
        external,
        variable,
        composite
    }

    public enum WCProductStockStatus
    {
        instock,
        outofstock,
        onbackorder
    }

    public enum WCProductOrderBy
    {
        date,
        id,
        include,
        title,
        slug,
        price,
        popularity,
        rating
    }

    public class WCProductVariationQueryParams : WCEntityQueryParams { }
}
