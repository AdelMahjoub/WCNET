namespace WCNET.WCRestApi.V3.WCQueryParams
{
    public class WCCouponQueryParams : WCEntityQueryParams
    {
        public string? code;
    }

    public enum WCCouponDiscountType
    {
        percent,
        fixed_cart,
        fixed_product
    }

    public enum WCCouponOrderBy
    {
        date, id, include, title, slug
    }
}
