using QuotesApp.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace QuotesApp
{
    class QuoteClient : IQuoteClient
    {
        private readonly HttpClient _httpClient;
        public QuoteClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<QuoteModal> AddQuote(QuoteWriteModal quote, string token)
        {
            var quoteJson = JsonSerializer.Serialize(quote);
            string url = $"quotes";
            var request = new HttpRequestMessage 
            { 
              Method = HttpMethod.Post, 
              RequestUri = new Uri(_httpClient.BaseAddress, url),
              Content = new StringContent(quoteJson, Encoding.UTF8, "application/json")
            };
            request.Headers.Add("User-Token", token);
            var response = await _httpClient.SendAsync(request);
            return await response.Content.ReadFromJsonAsync<QuoteModal>();
        }

        public async Task<QuoteModal> FavQuote(int quoteId, string token)
        {
            
            string url = $"quotes/{quoteId}/fav";
            var request = new HttpRequestMessage(HttpMethod.Put, new Uri(_httpClient.BaseAddress, url));
            request.Headers.Add("User-Token", token);
            var response = await _httpClient.SendAsync(request);
            return await response.Content.ReadFromJsonAsync<QuoteModal>();
        }

        public Task<QuoteModal> GetQuote(int quoteId)
        {
            string url = $"quotes/{quoteId}";
            return _httpClient.GetFromJsonAsync<QuoteModal>(url);
        }

        public async Task<QuotesModal> GetAllQuotes()
        {
            string url = $"quotes";
            
            return await _httpClient.GetFromJsonAsync<QuotesModal>(url);
        }
        public async Task<QuoteUserSesionModal> CreatSession(QuoteUserModal user)
        {
            string url = $"session";
            var response = await _httpClient.PostAsJsonAsync<QuoteUserModal>(url, user);
            return await response.Content.ReadFromJsonAsync<QuoteUserSesionModal>();
        }

        public async Task<string> DestroySession(string token)
        {
            string url = $"session";
            var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(_httpClient.BaseAddress, url));
            request.Headers.Add("User-Token", token);
            var response = await _httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> DeleteQuote(int quoteId, string token)
        {
            string url = $"quotes/{quoteId}";
            var request = new HttpRequestMessage(HttpMethod.Delete, new Uri(_httpClient.BaseAddress, url));
            request.Headers.Add("User-Token", token);
            var response = await _httpClient.SendAsync(request);
            return await response.Content.ReadAsStringAsync();
        }
    }
}
