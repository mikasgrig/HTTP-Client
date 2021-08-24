using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTPReqest.Models.Jsonplaceholder.ResponseModels
{
    public class TodoResponseModel
    {
        [JsonPropertyName("userId")]
        public int UserId { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("title")]
        public string Title { get; set; }
        [JsonPropertyName("completed")]
        public bool Completed { get; set; }
        public override string ToString()
        {
            return @$"USERid: {UserId}
ID: {Id}
title: {Title}
completed: {Completed}";
        }
    }
}
