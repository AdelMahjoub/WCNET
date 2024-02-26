using System.Text;
using WCNET.WCJsonSchema.V3.WCAttributes;
using WCNET.WCJsonSchema.V3.WCCategories;
using WCNET.WCJsonSchema.V3.WCCoupons;
using WCNET.WCJsonSchema.V3.WCCustomers;
using WCNET.WCJsonSchema.V3.WCData;
using WCNET.WCJsonSchema.V3.WCOrders;
using WCNET.WCJsonSchema.V3.WCPaymentGateways;
using WCNET.WCJsonSchema.V3.WCProducts;
using WCNET.WCJsonSchema.V3.WCReports;
using WCNET.WCJsonSchema.V3.WCReviews;
using WCNET.WCJsonSchema.V3.WCSettings;
using WCNET.WCJsonSchema.V3.WCShippingClasses;
using WCNET.WCJsonSchema.V3.WCShippingMethods;
using WCNET.WCJsonSchema.V3.WCShippingZones;
using WCNET.WCJsonSchema.V3.WCSystemStatus;
using WCNET.WCJsonSchema.V3.WCSystemStatusTools;
using WCNET.WCJsonSchema.V3.WCTags;
using WCNET.WCJsonSchema.V3.WCTaxClasses;
using WCNET.WCJsonSchema.V3.WCTaxRates;
using WCNET.WCJsonSchema.V3.WCWebHooks;
using WCNET.WCRestApi.V3.WCEntities;

namespace WCNET.WCRestApi.V3
{
    public class WCRestApi
    {
        public readonly string siteUrl;
        public readonly string endpoint = "wp-json/wc/v3/";
        public readonly string consumerKey;
        public readonly string consumerSecret;

        public WCRestApiParentEntity<WCCoupon> Coupons;

        public WCRestApiParentEntity<WCCustomer> Customers;
        public WCRestApiChildEntity<WCCustomerDownload> CustomerDownloads;

        public WCRestApiParentEntity<WCOrder> Orders;
        public WCRestApiChildEntity<WCOrderNote> OrderNotes;
        public WCRestApiChildEntity<WCOrderRefund> OrderRefunds;

        public WCRestApiParentEntity<WCProduct> Products;
        public WCRestApiChildEntity<WCProductVariation> ProductVariations;

        public WCRestApiParentEntity<WCAttribute> Attributes;
        public WCRestApiChildEntity<WCAttributeTerm> AttributeTerms;

        public WCRestApiParentEntity<WCCategory> Categories;

        public WCRestApiParentEntity<WCShippingClass> ShippingClasses;

        public WCRestApiParentEntity<WCTag> Tags;

        public WCRestApiParentEntity<WCReview> Reviews;

        public WCRestApiParentEntity<WCReport> Reports;
        public WCRestApiParentEntity<WCReportCouponTotal> ReportCouponsTotals;
        public WCRestApiParentEntity<WCReportTopSeller> ReportTopSellers;
        public WCRestApiParentEntity<WCReportSale> ReportSales;
        public WCRestApiParentEntity<WCReportCustomerTotal> ReportCustomersTotals;
        public WCRestApiParentEntity<WCReportOrderTotal> ReportOrdersTotals;
        public WCRestApiParentEntity<WCReportProductTotal> ReportProductsTotals;
        public WCRestApiParentEntity<WCReportReviewTotal> ReportReviewsTotals;

        public WCRestApiParentEntity<WCTaxRate> TaxRates;

        public WCRestApiParentEntity<WCTaxClass> TaxClasses;

        public WCRestApiParentEntity<WCWebhook> Webhooks;

        public WCRestApiParentEntity<WCSetting> Settings;
        public WCRestApiGroupedEntity<WCSettingOption> SettingOptions;

        public WCRestApiParentEntity<WCPaymentGateway> PaymentGateways;

        public WCRestApiParentEntity<WCShippingZone> ShippingZones;
        public WCRestApiChildEntity<WCShippingZoneLocation> ShippingZoneLocations;
        public WCRestApiChildEntity<WCShippingZoneMethod> ShippingZoneMethods;

        public WCRestApiParentEntity<WCShippingMethod> ShippingMethods;

        public WCRestApiParentEntity<WCSystemStatus> SystemStatus;

        public WCRestApiParentEntity<WCSystemStatusTool> SystemStatusTools;

        public WCRestApiParentEntity<WCData> Data;
        public WCRestApiParentEntity<WCDataContinent> DataContinents;
        public WCRestApiParentEntity<WCDataCountry> DataCountries;
        public WCRestApiParentEntity<WCDataCurrency> DataCurrencies;
        public WCRestApiParentEntity<WCDataCurrentCurrency> DataCurrentCurrency;

        public readonly HttpClient http;

        public WCRestApi(string siteUrl = "", string consumerKey = "", string consumerSecret = "")
        {

            this.siteUrl = siteUrl;
            this.consumerKey = consumerKey;
            this.consumerSecret = consumerSecret;

            //Utils.ValidateCredentials(siteUrl, consumerKey, consumerSecret);

            byte[] authToken = Encoding.UTF8.GetBytes($"{consumerKey}:{consumerSecret}");

            http = new();
            http.DefaultRequestHeaders.Authorization = new("Basic", Convert.ToBase64String(authToken));
            http.BaseAddress = new Uri(new Uri(siteUrl, UriKind.Absolute), new Uri(endpoint, UriKind.Relative));

            Coupons = new(http, "coupons");

            Customers = new(http, "customers");
            CustomerDownloads = new(http, "customers", "downloads");

            Orders = new(http, "orders");
            OrderNotes = new(http, "orders", "notes");
            OrderRefunds = new(http, "orders", "refunds");

            Products = new(http, "products");
            ProductVariations = new(http, "products", "variations");

            Attributes = new(http, "products/attributes");
            AttributeTerms = new(http, "products/attributes", "terms");

            Categories = new(http, "products/categories");

            ShippingClasses = new(http, "products/shipping_classes");

            Tags = new(http, "products/tags");

            Reviews = new(http, "products/reviews");

            Reports = new(http, "reports");
            ReportSales = new(http, "reports/sales");
            ReportTopSellers = new(http, "reports/top_sellers");
            ReportCouponsTotals = new(http, "reports/coupons/totals");
            ReportCustomersTotals = new(http, "reports/customers/totals");
            ReportOrdersTotals = new(http, "reports/orders/totals");
            ReportProductsTotals = new(http, "reports/products/totals");
            ReportReviewsTotals = new(http, "reports/reviews/totals");

            TaxRates = new(http, "taxes");

            TaxClasses = new(http, "taxes/classes");

            Webhooks = new(http, "webhooks");

            Settings = new(http, "settings");
            SettingOptions = new(http, "settings");

            PaymentGateways = new(http, "payment_gateways");

            ShippingZones = new(http, "shipping/zones");
            ShippingZoneLocations = new(http, "shipping/zones", "locations");
            ShippingZoneMethods = new(http, "shipping/zones", "methods");

            ShippingMethods = new(http, "shipping_methods");

            SystemStatus = new(http, "system_status");

            SystemStatusTools = new(http, "system_status/tools");

            Data = new(http, "data");
            DataContinents = new(http, "data/continents");
            DataCountries = new(http, "data/countries");
            DataCurrencies = new(http, "data/currencies");
            DataCurrentCurrency = new(http, "data/currencies/current");

        }

    }
}
