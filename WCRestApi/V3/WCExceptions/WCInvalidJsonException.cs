namespace WCNET.WCRestApi.V3.WCExceptions
{
    public class WCInvalidJsonException : Exception
    {
        public WCInvalidJsonException() : base() { }
        public WCInvalidJsonException(string message) : base(message) { }
        public WCInvalidJsonException(string message, Exception inner) : base(message, inner) { }
    }
}
