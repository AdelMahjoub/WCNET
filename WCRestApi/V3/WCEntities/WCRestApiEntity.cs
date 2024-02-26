using System.Text;
using Newtonsoft.Json;

namespace WCNET.WCRestApi.V3.WCEntities
{
    public class WCRestApiEntity<T>(HttpClient http)
    {
        protected HttpClient http = http;

        protected uint total = 0;
        protected uint totalPages = 0;
        protected string? nextPage;
        protected string? previousPage;

        public uint Total { get => total; set => total = value; }
        public uint TotalPages { get => totalPages; set => totalPages = value; }
        public string? NextPage { get => nextPage; set => nextPage = value; }
        public string? PreviousPage { get => previousPage; set => previousPage = value; }
        protected HttpClient Http { get => http; set => http = value; }

        protected async Task<T?> _Get<T>(string url)
        {

            HttpResponseMessage res = await Http.GetAsync(url);

            string? jsonString = await res.Content.ReadAsStringAsync();

            WCUtils.ThrowInvalidJsonFormat(jsonString);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonString);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        protected async Task<T?> _GetAll<T>(string url, string queryString = "")
        {
            HttpResponseMessage res = await Http.GetAsync($"{url}{queryString}");

            string? jsonString = await res.Content.ReadAsStringAsync();

            WCUtils.ThrowInvalidJsonFormat(jsonString);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonString);

            (Total, TotalPages) = WCUtils.GetCount(res);
            (NextPage, PreviousPage) = WCUtils.GetLinks(res);

            return JsonConvert.DeserializeObject<T>(jsonString);
        }

        protected async Task<T?> _Create<T>(string url, T entity)
        {
            JsonSerializerSettings settings = new() { NullValueHandling = NullValueHandling.Ignore };
            string? serializedEntity = JsonConvert.SerializeObject(entity, settings);
            StringContent content = new(serializedEntity, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Http.PostAsync(url, content);

            string? jsonResponse = await res.Content.ReadAsStringAsync();
            WCUtils.ThrowInvalidJsonFormat(jsonResponse);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonResponse);

            return JsonConvert.DeserializeObject<T?>(jsonResponse);
        }

        protected async Task<T?> _Update<T>(string url, T entity)
        {
            JsonSerializerSettings settings = new() { NullValueHandling = NullValueHandling.Ignore };
            string? serializedEntity = JsonConvert.SerializeObject(entity, settings);
            StringContent content = new(serializedEntity, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Http.PutAsync(url, content);

            string? jsonResponse = await res.Content.ReadAsStringAsync();
            WCUtils.ThrowInvalidJsonFormat(jsonResponse);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonResponse);

            return JsonConvert.DeserializeObject<T?>(jsonResponse);
        }

        protected async Task<T?> _Delete<T>(string url, bool force = true)
        {
            var req = new HttpRequestMessage(HttpMethod.Delete, url)
            {
                Content = new StringContent(
                JsonConvert.SerializeObject(new { force }),
                Encoding.UTF8,
                "application/json"
                )
            };
            HttpResponseMessage res = await Http.SendAsync(req);

            string? jsonResponse = await res.Content.ReadAsStringAsync();
            WCUtils.ThrowInvalidJsonFormat(jsonResponse);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonResponse);

            return JsonConvert.DeserializeObject<T?>(jsonResponse);
        }

        protected async Task<BatchResponse<T>?> _Batch<T>(string url, BatchRequest<T> req)
        {
            JsonSerializerSettings settings = new() { NullValueHandling = NullValueHandling.Ignore };
            string? serializedEntity = JsonConvert.SerializeObject(req, settings);
            StringContent content = new(serializedEntity, Encoding.UTF8, "application/json");
            HttpResponseMessage res = await Http.PostAsync($"{url}/batch", content);

            string? jsonResponse = await res.Content.ReadAsStringAsync();
            WCUtils.ThrowInvalidJsonFormat(jsonResponse);
            WCUtils.ThrowNonSuccessStatusCode(res, jsonResponse);

            return JsonConvert.DeserializeObject<BatchResponse<T>?>(jsonResponse);
        }
    }

    public class BatchRequest<T>
    {
        [JsonProperty("create")]
        public List<T>? Create;

        [JsonProperty("update")]
        public List<T>? Update;

        [JsonProperty("delete")]
        public List<uint>? Delete;
    }

    public class BatchResponse<T>
    {
        [JsonProperty("create")]
        public List<T>? Create;

        [JsonProperty("update")]
        public List<T>? Update;

        [JsonProperty("delete")]
        public List<T>? Delete;
    }
}
