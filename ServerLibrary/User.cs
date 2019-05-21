using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary {
    public static class User {
        private static Dictionary<string, string> dictionary;
        public static string Login {
            get {
                return dictionary["login"];
            }
            set {
                dictionary["login"] = value;
            }
        }
        public static string Password {
            get {
                return dictionary["password"];
            }
            set {
                dictionary["password"] = value;
            }
        }
        public static string Email {
            get {
                return dictionary["email"];
            }
            set {
                dictionary["email"] = value;
            }
        }

        public static void SetUser(string login, string password, string email = "") {
            dictionary = new Dictionary<string, string>() {
                {"login", login },
                {"password", password },
                {"email", email }
            };
        }

        public static async Task<JObject> VerifyLogin() {
            return await Connection.Get("api/user/check/login", Login);
        }

        public static async Task<JObject> VerifyPassword() {
            return await Connection.Get("api/user/check/password", Password);
        }

        public static async Task<JObject> Enter() {
            var dict = new Dictionary<string, string>() {
                {"login", Login },
                {"password", Password }
            };
            return await Connection.Post("api/user/login", dict);
        }

        public static async Task<JObject> Save() {
            return await Connection.Post("api/user/register", dictionary);
        }

        public static async Task<JObject> GetEmailVerif() {
            return await Connection.Get("api/user/email/getverification", Login);
        }

        public static async Task<JObject> SetEmailVerif(string verifcode) {
            var dict = new Dictionary<string, string>() {
                {"login", Login },
                {"verifcode", verifcode }
            };
            return await Connection.Post("api/user/email/setverification", dict);
        }
    }
}
