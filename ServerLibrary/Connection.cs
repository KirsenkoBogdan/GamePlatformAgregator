using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Security;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary {
    public static class Connection {
        private static readonly HttpClient client = new HttpClient();
        private static readonly string host = "https://192.168.0.106:81";

        public static async Task<JObject> Post(string url, Dictionary<string, string> dictionary) {
            client.Timeout = TimeSpan.MaxValue;
            var content = new FormUrlEncodedContent(dictionary);
            var copy = content.ReadAsStringAsync().Result;
            var fullurl = host + "/" + url + "/?" + copy;
            var response = await client.PostAsync(fullurl, null);
            var responseString = await response.Content.ReadAsStringAsync();
            return JObject.Parse(responseString);
        }

        public static async Task<JObject> Get(string url, string parameter) {
            client.Timeout = TimeSpan.MaxValue;
            var fullurl = host + "/" + url + "/" + parameter;
            var responseString = await client.GetStringAsync(fullurl);
            return JObject.Parse(responseString);
        }

        public static void NEVER_EAT_POISON_Disable_CertificateValidation() {
            // Disabling certificate validation can expose you to a man-in-the-middle attack
            // which may allow your encrypted message to be read by an attacker
            // https://stackoverflow.com/a/14907718/740639
            ServicePointManager.ServerCertificateValidationCallback =
                delegate (
                    object s,
                    X509Certificate certificate,
                    X509Chain chain,
                    SslPolicyErrors sslPolicyErrors
                ) {
                    return true;
                };
        }
    }
}
