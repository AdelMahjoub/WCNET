namespace WCNET.WCRestApi.V3.WCEntities
{
    public class WCRestApiGroupedEntity<T>(
        HttpClient http,
        string endpoint) : WCRestApiEntity<T>(http)
    {
        private string endpoint = endpoint;

        public async Task<T?> Get<T>(string groupId, string optionId)
        {
            return await _Get<T>($"{endpoint}/{groupId}/{optionId}");
        }

        public async Task<T?> GetAll<T>(string groupId = "")
        {
            return await _GetAll<T>($"{endpoint}/{groupId}");
        }

        public async Task<T?> Update<T>(string groupId, string optionId, T entity)
        {
            return await _Update<T>($"{endpoint}/{groupId}/{optionId}", entity);
        }

        public async Task<BatchResponse<T>?> Batch<T>(string groupid, BatchRequest<T> req)
        {
            return await _Batch<T>($"{endpoint}/{groupid}", req);
        }
    }
}
