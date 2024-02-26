namespace WCNET.WCRestApi.V3.WCQueryParams
{
    public class WCEntityQueryParams
    {
        public string context = WCEntityContext.view.ToString();
        public int? page = 1;
        public int? per_page = 10;
        public string? search;
        public string? after;
        public string? before;
        public string? modified_after;
        public string? modified_before;
        public bool? dates_are_gmt;
        public List<uint>? exclude;
        public List<uint>? include;
        public int? offset;
        public string? order = WCEntitytOrder.desc.ToString();
        public string? orderby;
        public override string? ToString()
        {
            return WCUtils.BuildQueryString(this);
        }
    }
    public enum WCEntityContext
    {
        view,
        edit
    }

    public enum WCEntitytOrder
    {
        asc,
        desc,
    }
}
