using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary {
    public static class Connection {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string host = "https://localhost:44348";

        public static async Task<JObject> Post(string url, Dictionary<string,string> dictionary) {
            var content = new FormUrlEncodedContent(dictionary);
            var copy = content.ReadAsStringAsync().Result;
            var fullurl = host + "/" + url + "/?" + copy;
            var response = await client.PostAsync(fullurl, null);
            var responseString = await response.Content.ReadAsStringAsync();
            return JObject.Parse(responseString);
        }

        public static async Task<JObject> Get(string url, string parameter) {
            var fullurl = host + "/" + url + "/" + parameter;
            var responseString = await client.GetStringAsync(fullurl);
            return JObject.Parse(responseString);
        }
    }
}
