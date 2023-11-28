using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarpinteriaFront.Servicios
{
    public class ClienteSingleton
    {
        private static ClienteSingleton intstancia;
        private HttpClient client;
        private ClienteSingleton() 
        {
            client = new HttpClient();
        }
        public static ClienteSingleton GetInstancia()
        {
            if (intstancia == null) { intstancia = new ClienteSingleton(); }
            return intstancia;
        }
        public async Task <string> GetAsync(string url)
        {
            var result = await client.GetAsync(url);
            var content = "";
            if (result.StatusCode == System.Net.HttpStatusCode.OK)
            {
                content = await result.Content.ReadAsStringAsync();
            }
            return content;
        }
        public async Task<string> PostAsync(string urlPost, string DataJson)
        {
            StringContent content = new StringContent(DataJson, Encoding.UTF8, "application/json");
            var result = await client.PostAsync(urlPost, content);
            var response = "";
            if (result.IsSuccessStatusCode)
            {
                response = await result.Content.ReadAsStringAsync();
            }
            return response;
        }
    }
}
