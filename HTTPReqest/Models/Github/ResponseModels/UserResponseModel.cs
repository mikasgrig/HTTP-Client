using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTPReqest.Models.Github.ResponseModels
{
    public class UserResponseModel
    {
        [JsonPropertyName("login")]
        public string Login { get; set; }
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }
        public override string ToString()
        {
            return $"{Login}  {Id}  {NodeId}";
        }
    }
}
