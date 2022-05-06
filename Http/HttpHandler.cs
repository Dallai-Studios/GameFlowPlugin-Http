using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace GameFlow.Plugins.Http
{
    public static class HttpHandler
    {
        private static readonly HttpClient client = new HttpClient();

        private static void InitializeClient()
        {
            HttpHandler.client.DefaultRequestHeaders.Accept.Clear();
            HttpHandler.client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public static async Task<Response> Get(string url)
        {
            HttpHandler.InitializeClient();
            Response response = (Response) await HttpHandler.client.GetAsync(url);
            return response;
        }

        public static async Task<Response> Post(string url, Request payload)
        {
            HttpHandler.InitializeClient();
            Response response = (Response) await HttpHandler.client.PostAsync(url, payload);
            return response;
        }

        public static async Task<Response> Put(string url, Request payload)
        {
            HttpHandler.InitializeClient();
            Response response = (Response)await HttpHandler.client.PutAsync(url, payload);
            return response;
        }

        public static async Task<Response> Delete(string url)
        {
            HttpHandler.InitializeClient();
            Response response = (Response) await HttpHandler.client.DeleteAsync(url);
            return response;
        }
    }
}
