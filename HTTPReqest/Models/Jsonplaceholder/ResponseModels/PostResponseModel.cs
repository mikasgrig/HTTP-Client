using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTPReqest.Models.Jsonplaceholder.ResponseModels
{
    public class PostResponseModel
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
}
