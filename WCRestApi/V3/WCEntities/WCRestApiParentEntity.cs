namespace WCNET.WCRestApi.V3.WCEntities
{
    public class WCRestApiParentEntity<T>(HttpClient http, string endpoint) : WCRestApiEntity<T>(http)
    {
        private string endpoint = endpoint;

        public string Endpoint { get => endpoint; set => endpoint = value; }

        public async Task<T?> Get<T>(string id)
        {
            return await _Get<T>($"{Endpoint}/{id}");
        }

        public async Task<T?> GetAll<T>(string queryString = "")
        {
            return await _GetAll<T>($"{Endpoint}", queryString);
        }

        public async Task<T?> Create<T>(T entity)
        {
            return await _Create($"{Endpoint}", entity);
        }

        public async Task<T?> Update<T>(string id, T entity)
        {
            return await _Update($"{Endpoint}/{id}", entity);
        }

        public async Task<T?> Delete<T>(string id, bool force = true)
        {
            return await _Delete<T>($"{Endpoint}/{id}", force);
        }

        public async Task<BatchResponse<T>?> Batch<T>(BatchRequest<T> req)
        {
            return await _Batch($"{Endpoint}/batch", req);
        }

    }


}
