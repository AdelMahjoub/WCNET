namespace WCNET.WCRestApi.V3.WCQueryParams
{
    public class WCCustomerQueryParams : WCEntityQueryParams
    {
        public string? email;
        public string? role;
    }

    enum WCCustomerOrderBy
    {
        id, include, name, registered_date
    }

    enum WCCustomerRole
    {
        all, administrator, editor, author, contributor, subscriber, customer, shop_manager
    }
}
