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
        public async static Task<T> Get<T>(string ControllerName, string Route, string Param, string token = "") where T : class
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (token != "")
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                }
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

                HttpResponseMessage response = await client.GetAsync("api/" + ControllerName + (Route != "" ? ("/" + Route) : "") + (Param != "" ? ("?" + Param) : ""));
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<T>().Result;
                    return data;
                }
            }
            return null;
        }
        public async static Task<List<T>> GetMulti<T>(string ControllerName, string Route, string Param, string token = "") 
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (token != "")
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                }
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");

                HttpResponseMessage response = client.GetAsync("api/" + ControllerName + (Route != "" ? ("/" + Route) : "") + (Param != "" ? ("?" + Param) : "")).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<List<T>>().Result;
                    return data;
                }
            }
            return null;
        }
        public static Task<T> Post<T, K>(string ControllerName, string Route, K item, string token = "")
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                if (token != "")
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                }
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
        public static Task<T> PostWithFile<T>(string ControllerName, string Route, MultipartContent newItem, string token = "")
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
                if (token != "")
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                }
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
                HttpResponseMessage response = client.PostAsync("api/" + ControllerName + (Route != "" ? ("/" + Route) : ""), newItem).Result;
                if (response.IsSuccessStatusCode)
                {
                    var data = response.Content.ReadAsAsync<T>();
                    return data;
                }
            }
            return null;
        }
        public static Task<T> PutWithFile<T>(string ControllerName, string Route, MultipartContent newItem, string token = "") where T : class
        {
            using (var client = new HttpClient())
            {

                client.BaseAddress = new Uri(BaseURL);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("multipart/form-data"));
                if (token != "")
                {
                    client.DefaultRequestHeaders.Add("Authorization", "Bearer " + token);

                }
                client.DefaultRequestHeaders.TryAddWithoutValidation("Content-Type", "application/x-www-form-urlencoded; charset=utf-8");
                HttpResponseMessage response = client.PutAsync("api/" + ControllerName + (Route != "" ? ("/" + Route) : ""), newItem).Result;
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
