using System.Text.Json;
using Newtonsoft.Json;

namespace WCNET.WCJsonSchema.V3.WCProducts
{
    public class WCProduct : WCEntity
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("permalink")]
        public string? Permalink { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("type")]
        public string? Type { get; set; }

        [JsonProperty("status")]
        public string? Status { get; set; }

        [JsonProperty("featured")]
        public bool? Featured { get; set; }

        [JsonProperty("catalog_visibility")]
        public string? CatalogVisibility { get; set; }

        [JsonProperty("description")]
        public string? Description { get; set; }

        [JsonProperty("short_description")]
        public string? ShortDescription { get; set; }

        [JsonProperty("sku")]
        public string? Sku { get; set; }

        [JsonProperty("price")]
        public string? Price { get; set; }

        [JsonProperty("regular_price")]
        public string? RegularPrice { get; set; }

        [JsonProperty("sale_price")]
        public string? SalePrice { get; set; }

        [JsonProperty("date_on_sale_from")]
        public DateTime? DateOnSaleFrom { get; set; }

        [JsonProperty("date_on_sale_from_gmt")]
        public DateTime? DateOnSaleFromGmt { get; set; }

        [JsonProperty("date_on_sale_to")]
        public DateTime? DateOnSaleTo { get; set; }

        [JsonProperty("date_on_sale_to_gmt")]
        public DateTime? DateOnSaleToGmt { get; set; }

        [JsonProperty("on_sale")]
        public bool? OnSale { get; set; }

        [JsonProperty("purchasable")]
        public bool? Purchasable { get; set; }

        [JsonProperty("total_sales")]
        public int? TotalSales { get; set; }

        [JsonProperty("virtual")]
        public bool? Virtual { get; set; }

        [JsonProperty("downloadable")]
        public bool? Downloadable { get; set; }

        [JsonProperty("downloads")]
        public List<_ProductDownload>? Downloads { get; set; }

        [JsonProperty("download_limit")]
        public int? DownloadLimit { get; set; }

        [JsonProperty("download_expiry")]
        public int? DownloadExpiry { get; set; }

        [JsonProperty("external_url")]
        public string? ExternalUrl { get; set; }

        [JsonProperty("button_text")]
        public string? ButtonText { get; set; }

        [JsonProperty("tax_status")]
        public string? TaxStatus { get; set; }

        [JsonProperty("tax_class")]
        public string? TaxClass { get; set; }

        [JsonProperty("manage_stock")]
        public bool? ManageStock { get; set; }

        [JsonProperty("stock_quantity")]
        public double? StockQuantity { get; set; }

        [JsonProperty("backorders")]
        public string? Backorders { get; set; }

        [JsonProperty("backorders_allowed")]
        public bool? BackordersAllowed { get; set; }

        [JsonProperty("backordered")]
        public bool? Backordered { get; set; }

        [JsonProperty("low_stock_amount")]
        public double? LowStockAmount { get; set; }

        [JsonProperty("sold_individually")]
        public bool? SoldIndividually { get; set; }

        [JsonProperty("weight")]
        public string? Weight { get; set; }

        [JsonProperty("shipping_required")]
        public bool? ShippingRequired { get; set; }

        [JsonProperty("shipping_taxable")]
        public bool? ShippingTaxable { get; set; }

        [JsonProperty("shipping_class")]
        public string? ShippingClass { get; set; }

        [JsonProperty("shipping_class_id")]
        public int? ShippingClassId { get; set; }

        [JsonProperty("reviews_allowed")]
        public bool? ReviewsAllowed { get; set; }

        [JsonProperty("average_rating")]
        public string? AverageRating { get; set; }

        [JsonProperty("rating_count")]
        public string? RatingCount { get; set; }

        [JsonProperty("parent_id")]
        public uint? ParentId { get; set; }

        [JsonProperty("purchase_note")]
        public string? PurchaseNote { get; set; }

        [JsonProperty("menu_order")]
        public int? MenuOrder { get; set; }

        [JsonProperty("price_html")]
        public string? PriceHtml { get; set; }

        [JsonProperty("stock_status")]
        public string? StockStatus { get; set; }

        [JsonProperty("has_options")]
        public bool? HasOptions { get; set; }

        [JsonProperty("post_password")]
        public string? PostPassword { get; set; }

        [JsonProperty("images")]
        public List<_ProductImage>? Images { get; set; }

        [JsonProperty("attributes")]
        public List<_ProductAttribute>? Attributes { get; set; }

        [JsonProperty("dimensions")]
        public _ProductDimensions? Dimensions { get; set; }

        [JsonProperty("upsell_ids")]
        public List<uint>? UpSellIds { get; set; }

        [JsonProperty("cross_sell_ids")]
        public List<uint>? CrossSellIds { get; set; }

        [JsonProperty("categories")]
        public List<_ProductCategory>? Categories { get; set; }

        [JsonProperty("tags")]
        public List<_ProductTag>? Tags { get; set; }

        [JsonProperty("default_attributes")]
        public List<_ProductAttribute>? DefaultAttributes { get; set; }

        [JsonProperty("variations")]
        public List<uint>? Variations { get; set; }

        [JsonProperty("related_ids")]
        public List<uint>? RelatedIds { get; set; }

        [JsonProperty("grouped_products")]
        public List<uint>? GroupedProducts { get; set; }
    }

    public class _ProductAttribute
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }

        [JsonProperty("position")]
        public int? Position { get; set; }

        [JsonProperty("visible")]
        public bool? Visible { get; set; }

        [JsonProperty("variation")]
        public bool? Variation { get; set; }

        [JsonProperty("options")]
        public List<string>? Options { get; set; }
    }

    public class _ProductCategory
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }
    }

    public class _ProductDimensions
    {
        [JsonProperty("length")]
        public string? Length { get; set; }

        [JsonProperty("width")]
        public string? Width { get; set; }

        [JsonProperty("height")]
        public string? Height { get; set; }
    }

    public class _ProductDownload
    {
        [JsonProperty("id")]
        public string? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("file")]
        public string? File { get; set; }
    }

    public class _ProductImage
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty("date_created_gmt")]
        public DateTime? DateCreatedGmt { get; set; }

        [JsonProperty("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty("date_modified_gmt")]
        public DateTime? DateModifiedGmt { get; set; }

        [JsonProperty("src")]
        public string? Src { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("alt")]
        public string? Alt { get; set; }
    }
    public class _ProductTag
    {
        [JsonProperty("id")]
        public uint? Id { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("slug")]
        public string? Slug { get; set; }
    }
}
