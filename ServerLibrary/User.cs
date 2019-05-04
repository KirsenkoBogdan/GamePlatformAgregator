using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerLibrary {
    public class User {
        private Dictionary<string, string> dictionary;
        public string Login {
            get {
                return dictionary["login"];
            }
            set {
                dictionary["login"] = value;
            }
        }
        public string Password {
            get {
                return dictionary["password"];
            }
            set {
                dictionary["password"] = value;
            }
        }
        public string Email {
            get {
                return dictionary["email"];
            }
            set {
                dictionary["email"] = value;
            }
        }

        public User(string login, string password) : this(login, password, "") {
        }

        public User(string login, string password, string email) {
            dictionary = new Dictionary<string, string>() {
                {"login", login },
                {"password", password },
                {"email", email }
            };
        }

        public async Task<JObject> VerifyLogin() {
            return await Connection.Get("api/user/check/login", Login);
        }

        public async Task<JObject> VerifyPassword() {
            return await Connection.Get("api/user/check/password", Password);
        }

        public async Task<JObject> Enter() {
            var dict = new Dictionary<string, string>() {
                {"login", Login },
                {"password", Password }
            };
            return await Connection.Post("api/user/login", dict);
        }

        public async Task<JObject> Save() {
            return await Connection.Post("api/user/register", dictionary);
        }
    }
}
