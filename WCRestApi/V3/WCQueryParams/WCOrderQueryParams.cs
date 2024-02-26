namespace WCNET.WCRestApi.V3.WCQueryParams
{
    public class WCOrderQueryParams : WCEntityQueryParams
    {
        public List<uint>? parent { get; set; }
        public List<uint>? parent_exclude { get; set; }
        public List<string>? status { get; set; }
        public uint? customer { get; set; }
        public uint? product { get; set; }
        public int? dp { get; set; }

    }

    public enum WCOrderStatus
    {
        ny, pending, processing, completed, cancelled, refunded, failed, trash
    }

    public class WCOrderNoteQueryParams : WCEntityQueryParams
    {
        public string? type;
    }

    public enum WCOrderNoteType
    {
        any, customer, @internal
    }

    public class WCOrderRefundQueryParams : WCEntityQueryParams
    {
        public List<uint>? parent { get; set; }
        public List<uint>? parent_exclude { get; set; }

        public int? dp;
    }
}
