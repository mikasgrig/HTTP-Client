using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuotesApp.Modals
{
    public class QuotesModal
    {
        [JsonPropertyName("page")]
        public int Page { get; set; }
        [JsonPropertyName("last_page")]
        public bool LastPage { get; set; }
        [JsonPropertyName("quotes")]
        public List<QuoteModal> Qoutes { get; set; }
    }
}
