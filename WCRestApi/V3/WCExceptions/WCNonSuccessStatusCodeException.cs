namespace WCNET.WCRestApi.V3.WCExceptions
{
    public class WCNonSuccessStatusCodeException : Exception
    {
        public WCNonSuccessStatusCodeException() : base() { }
        public WCNonSuccessStatusCodeException(string message) : base(message) { }
        public WCNonSuccessStatusCodeException(string message, Exception inner) : base(message, inner) { }
    }
}
