using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ZapateriaPresentacion.Client
{
    public class Client
    {
        private static Lazy<Client> _instance = new Lazy<Client>(() => new Client());
        const string _URL = "https://localhost:44388/";

        public static Client Instance
        {
            get => _instance.Value;
        }
        internal T PostAsync<T>(object obj, string path) where T : new()
        {
            try
            {
                var json = JsonConvert.SerializeObject(obj);

                var stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpClient httpClient = new HttpClient();

                var headers = httpClient.DefaultRequestHeaders;
                Uri requestUri = new Uri(_URL + path);

                HttpResponseMessage httpResponse = null;
                try
                {
                    httpResponse = httpClient.PostAsync(requestUri, stringContent).GetAwaiter().GetResult();
                    httpResponse.EnsureSuccessStatusCode();
                    string httpResponseBody = httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var result = JsonConvert.DeserializeObject<T>(httpResponseBody);
                    httpClient.Dispose();
                    return result;
                }
                catch (Exception)
                {
                    return default(T);
                }
            }
            catch (Exception)
            {
                return default(T);
            }
        }

        internal T GetAsync<T>(string path, bool ui = true) where T : new()
        {
            try
            {
                HttpClient httpClient = new HttpClient();

                var headers = httpClient.DefaultRequestHeaders;
                headers.Remove("Authorization");

                Uri requestUri = new Uri(_URL + path);

                HttpResponseMessage httpResponse = null;
                try
                {
                    httpResponse = httpClient.GetAsync(requestUri).GetAwaiter().GetResult();
                    httpResponse.EnsureSuccessStatusCode();
                    string httpResponseBody = httpResponse.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                    var result = JsonConvert.DeserializeObject<T>(httpResponseBody);
                    httpClient.Dispose();
                    return result;
                }
                catch (Exception)
                {
                   
                    return default(T);
                }
            }
            catch (Exception)
            {
                return default(T);
            }
        }
    }
}
