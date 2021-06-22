using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace HostelManagement.API
{
    public static class BaseAPI
    {
        private const string BaseURL = "https://localhost:44358/";
        public async static Task<T> Get<T>(string ControllerName, string Route, string Param) where T : class
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

                HttpResponseMessage response = await client.GetAsync("api/" + ControllerName + Route != "" ?  ("/" + Route) : "" + Param != "" ? ("?" + Param) : "");
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<T>().Result;
                    return data;
                }
            }
            return null;
        }
        public async static Task<IEnumerable<T>> GetMulti<T>(string ControllerName, string Route, string Param) where T : class
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

                HttpResponseMessage response = await client.GetAsync("api/" + ControllerName + Route != "" ? ("/" + Route) : "" + Param != "" ? ("?" + Param) : "");
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<IEnumerable<T>>().Result;
                    return data;
                }
            }
            return null;
        }
        public static Task<T> Post<T, K>(string ControllerName, string Route, K item) where T : class
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
                HttpResponseMessage response = client.PostAsJsonAsync("api/" + ControllerName + (Route != "" ? ("/" + Route) : ""), item).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<T>();
                    return data;
                }
            }
            return null;
        }
    }
}
