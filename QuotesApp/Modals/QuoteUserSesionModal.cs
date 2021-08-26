using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuotesApp.Modals
{
    public class QuoteUserSesionModal
    {
        [JsonPropertyName("User-Token")]
        public string UserToken { get; set; }
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        public override string ToString()
        {
            return $@"User Token: {UserToken}
login: {Login}";
        }
    }
}
