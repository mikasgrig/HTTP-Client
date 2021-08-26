using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuotesApp.Modals
{
    public class QuoteWriteModal
    {
        [JsonPropertyName("quote")]
        public Quote QuoteNew { get; set; }
        public class Quote
        {
            [JsonPropertyName("author")]
            public string Author { get; set; }
            [JsonPropertyName("body")]
            public string Body { get; set; }
        }
    }

}
