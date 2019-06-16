using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary {
    public static class EnterPlatform {
        private static readonly string ClientId = "46899977096215655";
        private static readonly string ClientSecret = "9d85c43b1482497dbbce61f6e4aa173a433796eeae2ca8c5f6129f2dc4de46d9";
        private static readonly string RedirectedUri = "https%3A%2F%2Fembed.gog.com%2Fon_login_success%3Forigin%3Dclient";

        public static string OAuthString() {
            return "https://auth.gog.com/auth?client_id="+ClientId+"&redirect_uri="+RedirectedUri+"&response_type=code&layout=client2";
        }

        public static string TokenString(string usercode) {
            var grandtype = "authorization_code";
            return "https://auth.gog.com/token?client_id="+ClientId+"&client_secret="+ClientSecret+"&grant_type="+grandtype+"&code=" + usercode + "&redirect_uri="+RedirectedUri;
        }
    }
}
