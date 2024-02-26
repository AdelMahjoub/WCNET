using System.Text;
using System.Text.Json;
using System.Web;
using WCNET.WCRestApi.V3.WCExceptions;

namespace WCNET.WCRestApi.V3
{
    public static class WCUtils
    {
        public static bool IsValidJson(string source)
        {
            if (source is null)
            {
                return false;
            }
            try
            {
                JsonDocument.Parse(source);
                return true;
            }
            catch (System.Text.Json.JsonException)
            {
                return false;
            }
        }

        public static void ThrowInvalidJsonFormat(string json)
        {
            if (!IsValidJson(json))
                throw new WCInvalidJsonException(json);
        }

        public static void ThrowNonSuccessStatusCode(HttpResponseMessage res, string json)
        {
            if (!res.IsSuccessStatusCode)
                throw new WCNonSuccessStatusCodeException(json);
        }

        public static (uint total, uint totalPages) GetCount(HttpResponseMessage res)
        {
            uint total = 0;
            uint totalPages = 0;
            res.Headers.TryGetValues("x-wp-total", out IEnumerable<string>? xWpTotalValues);
            res.Headers.TryGetValues("x-wp-totalpages", out IEnumerable<string>? xWpTotalPagesValues);
            string? totalString = (xWpTotalValues is not null && xWpTotalValues.Any()) ? xWpTotalValues.First() : null;
            string? totalPagesString = (xWpTotalPagesValues is not null && xWpTotalPagesValues.Any()) ? xWpTotalPagesValues.First() : null;
            try
            {
                total = totalString is not null ? Convert.ToUInt32(totalString) : 0;
                totalPages = totalPagesString is not null ? Convert.ToUInt32(totalPagesString) : 0;
            }
            catch { }
            return (total, totalPages);
        }

        public static (string? nextPage, string? previousPage) GetLinks(HttpResponseMessage res)
        {
            string? nextPage = null;
            string? previousPage = null;

            res.Headers.TryGetValues("link", out IEnumerable<string>? linkHeaderValues);
            if (linkHeaderValues is not null && linkHeaderValues.Any())
            {
                foreach (var item in linkHeaderValues)
                {
                    string[] itemParts = item.Split(';');
                    string rel = itemParts[1].Replace("rel=", "").Trim();
                    string url = itemParts[0].Replace("<", "").Replace(">", "").Trim();
                    switch (rel)
                    {
                        case "\"next\"":
                            nextPage = url;
                            break;
                        case "\"previous\"":
                            previousPage = url;
                            break;
                    }
                }
            }
            return (nextPage, previousPage);
        }

        public static void ValidateCredentials(string siteUrl, string consumerKey, string consumerSecret)
        {
            bool nullOrEmpty = siteUrl is null || consumerKey is null || consumerSecret is null
                || siteUrl.Length == 0 || consumerKey.Length == 0 || consumerSecret.Length == 0;

            if (nullOrEmpty)
                throw new ArgumentException("Credential value cannot be null or empty");
            if (!Uri.IsWellFormedUriString(siteUrl, UriKind.Absolute))
                throw new ArgumentException("Invalid siteUrl");
        }

        public static string? BuildQueryString(object o)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            o.GetType().GetFields().ToList().ForEach(field =>
            {
                var key = field.Name;
                var value = field.GetValue(o);
                if (value != null)
                {
                    var type = value.GetType().Name;
                    switch (type)
                    {
                        case "List`1":
                            try
                            {
                                var list = (List<uint>)value;
                                var listValue = new StringBuilder("");
                                list.ForEach(item =>
                                {
                                    listValue.Append($"{item.ToString()},");
                                });
                                listValue = listValue.Remove(listValue.Length - 1, 1);
                                query[key] = listValue.ToString();
                            }
                            catch { }
                            break;
                        default:
                            query[key] = value.ToString();
                            break;
                    }
                }
            });

            return query.ToString();
        }
    }
}
