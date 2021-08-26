using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace QuotesApp.Modals
{
    public class QuoteModal
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("dialogue")]
        public bool Dialogue { get; set; }
        [JsonPropertyName("private")]
        public bool Private { get; set; }
        [JsonPropertyName("tags")]
        public IEnumerable<string> Tags { get; set; }
        [JsonPropertyName("url")]
        public string Url { get; set; }
        [JsonPropertyName("favorites_count")]
        public int FavoritesCount { get; set; }
        [JsonPropertyName("author")]
        public string Author { get; set; }
        [JsonPropertyName("body")]
        public string Body { get; set; }
        [JsonPropertyName("favorite")]
        public bool Favorite { get; set; }
        public override string ToString()
        {
            return $"{Id} {Author} {Body}";
        }
    }
}
