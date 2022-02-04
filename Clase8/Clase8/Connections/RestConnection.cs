using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Clase8.Connections
{
    public class RestConnection
    {
        public RestConnection()
        {
        }

        private HttpClient _httpClient;
        private string UriBase;

        public RestConnection(string uriBase)
        {
            this.UriBase = uriBase;
            this._httpClient = new HttpClient();
        }

        public async Task<T> GetAsync<T>(string partialUri)
        {
            string uri = this.GetUri(partialUri);
            HttpResponseMessage response = await this._httpClient.GetAsync(uri);

            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        public async Task<T> PostAsync<T, U>(string partialUri, U item)
        {
            string uri = this.GetUri(partialUri);
            string bodyContent = JsonConvert.SerializeObject(item);
            HttpContent content = new StringContent(bodyContent, Encoding.UTF8, "application/json");


            HttpResponseMessage response = await this._httpClient.PostAsync(uri, content);
            string json = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<T>(json);
        }

        private string GetUri(string partialUri)
        {
            return string.Format("{0}/{1}", this.UriBase, partialUri);
        }
    }
}
