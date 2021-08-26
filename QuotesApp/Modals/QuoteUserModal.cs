﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuotesApp.Modals
{
    public class QuoteUserModal
    {
        [JsonPropertyName("user")]
        public User UserNew { get; set; }

        public class User
        {
            [JsonPropertyName("login")]
            public string Login { get; set; }
            [JsonPropertyName("password")]
            public string Password { get; set; }
        }
    }
}
