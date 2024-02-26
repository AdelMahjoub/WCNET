namespace WCNET.WCRestApi.V3.WCEntities
{
    public class WCRestApiChildEntity<T>(
        HttpClient http, string parentendpoint, string endpoint) : WCRestApiEntity<T>(http)
    {
        private string parentendpoint = parentendpoint;
        private string endpoint = endpoint;

        public async Task<T?> Get<T>(string parentId, string id)
        {
            return await _Get<T>($"{parentendpoint}/{parentId}/{endpoint}/{id}");
        }

        public async Task<T?> GetAll<T>(string parentId, string queryString = "")
        {
            return await _GetAll<T>($"{parentendpoint}/{parentId}/{endpoint}", queryString);
        }

        public async Task<T?> Create<T>(string parentId, T entity)
        {
            return await _Create($"{parentendpoint}/{parentId}/{endpoint}", entity);
        }

        public async Task<T?> Update<T>(string parentId, string id, T entity)
        {
            return await _Update($"{parentendpoint}/{parentId}/{endpoint}/{id}", entity);
        }

        public async Task<T?> Delete<T>(string parentId, string id, bool force = true)
        {
            return await _Delete<T>($"{parentendpoint}/{parentId}/{endpoint}/{id}", force);
        }

        public async Task<BatchResponse<T>?> Batch<T>(string parentId, BatchRequest<T> req)
        {
            return await _Batch($"{parentendpoint}/{parentId}/{endpoint}/batch", req);
        }
    }
}
