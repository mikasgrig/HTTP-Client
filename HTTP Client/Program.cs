using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTP_Client
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var httpClient = new HttpClient();
            var httpUri = "https://jsonplaceholder.typicode.com/posts/1";
            /*           var request = new HttpRequestMessage();
                       request.RequestUri = new Uri("https://jsonplaceholder.typicode.com/posts?userId=1");
                       var response = await httpClient.SendAsync(request);

                       var responseString = await response.Content.ReadAsStringAsync();
                       var postas =  JsonSerializer.Deserialize<List<Post>>(responseString);
                       foreach (var item in postas)
                       {
                           Console.WriteLine(item.ToString());
                       }*/
            /* var response = await httpClient.GetAsync("https://jsonplaceholder.typicode.com/posts?userId=1");
             var post = await response.Content.ReadFromJsonAsync<List<Post>>();*/
            //var post = await httpClient.GetFromJsonAsync<List<PostResponse>>("https://jsonplaceholder.typicode.com/posts?userId=1");

            var post1 = new PostRequest
            {
                userId = 2,
                title = "asdfas",
                body = "Mikas",
                Id = 2
            };
            var post2 = new PostRequestPatchTitle
            {
                title = "Mikas",
            };

            /*                     var postJson = JsonSerializer.Serialize(post1);

                                 var request = new HttpRequestMessage();
                                 request.RequestUri = new Uri(httpUri);
                                 request.Method = HttpMethod.Post;
                                 request.Content = new StringContent(postJson, Encoding.UTF8, "application/json");

                                 var response = await httpClient.SendAsync(request);

                                 var postResponse = await response.Content.ReadFromJsonAsync<PostResponse>();*/
            //var response = await httpClient.PostAsJsonAsync(httpUri, post1);
            /*var postJson = JsonSerializer.Serialize(new { body = "Foot" });*/
            var postJson = JsonSerializer.Serialize(post2);
            var request = new HttpRequestMessage();
            request.RequestUri = new Uri(httpUri);
            request.Method = HttpMethod.Delete;
/*            request.Content = new StringContent(postJson, Encoding.UTF8, "application/json");
*/            var response = await httpClient.SendAsync(request);
            Console.WriteLine(response.StatusCode);
        }
        class PostResponse
        {
            [JsonPropertyName("userId")]
            public int UserId { get; set; }
            [JsonPropertyName("id")]
            public int Id { get; set; }
            [JsonPropertyName("title")]
            public string ManoTitle { get; set; }
            [JsonPropertyName("body")]
            public string ManoBodys { get; set; }
            public override string ToString()
            {
                return @$"user id:{UserId}, 
id: {Id}, 
Title: {ManoTitle}, 
Body: {ManoBodys},";
            }
        }
        class PostRequest
        {
            public int userId { get; set; }
            public string title { get; set; }
            public string body { get; set; }
            public int Id { get; set; }
            public override string ToString()
            {
                return @$"user id:{userId}, 
Title: {title}, 
Body: {body},";
            }
        }
        class PostRequestPatchTitle
        {
            public string title { get; set; }
            
        }
    }
}
