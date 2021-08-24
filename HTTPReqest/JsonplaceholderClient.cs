using HTTPReqest.Models.Jsonplaceholder.ResponseModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace HTTPReqest
{
    public class JsonplaceholderClient : IJsonPlaceholderClient
    {
        private readonly HttpClient _httpClient;
        public JsonplaceholderClient(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public Task<PostResponseModel> GetPost()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<PostResponseModel>> GetPosts()
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<TodoResponseModel>> GetTodoItems(int id)
        {
            string url = $"/todos?userId={id}";
            return _httpClient.GetFromJsonAsync<IEnumerable<TodoResponseModel>>(url);
        }

        public Task<IEnumerable<TodoResponseModel>> GetTodosByStatus(int id, bool isCompleted)
        {
            var isCompletedString = Convert.ToString(isCompleted).ToLower();
            
            string url = $"/todos?userId={id}&completed={isCompletedString}";
            return _httpClient.GetFromJsonAsync<IEnumerable<TodoResponseModel>>(url);
        }

        public async Task<UserResponseModel> GetUser(int id)
        {
            string url = $"/users?id={id}";
            var result = await _httpClient.GetFromJsonAsync<IEnumerable<UserResponseModel>>(url);
            return result.First();
        }

        public Task<IEnumerable<UserResponseModel>> GetUsers()
        {
            const string url = "/users";
            return _httpClient.GetFromJsonAsync<IEnumerable<UserResponseModel>>(url);
        }
    }
}
