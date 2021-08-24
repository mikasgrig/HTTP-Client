using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace HTTPReqest.Models.Jsonplaceholder.ResponseModels
{
    public class UserResponseModel
    {
        [JsonPropertyName("Id")]
        public int Id { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("username")]
        public string Username { get; set; }
        [JsonPropertyName("email")]
        public string Email { get; set; }
        [JsonPropertyName("phone")]
        public string Phone { get; set; }
        [JsonPropertyName("website")]
        public string Website { get; set; }

        public address Address { get; set; }
        public company Company { get; set; }

        public class address
        {
            [JsonPropertyName("street")]
            public string Street { get; set; }
            [JsonPropertyName("suite")]
            public string Suite { get; set; }
            [JsonPropertyName("city")]
            public string City { get; set; }
            [JsonPropertyName("zipcode")]
            public string Zipcode { get; set; }
            public Geo Geo { get; set; }

            public override string ToString()
            {
                return @$"
    Street: {Street}
    Suite: {Suite}
    City: {City}
    Zipcode: {Zipcode}
    Geo: {Geo}";
            }
        }
        public class company
        {
            [JsonPropertyName("name")]
            public string Name { get; set; }
            [JsonPropertyName("catchPhrase")]
            public string CatchPhrase { get; set; }
            [JsonPropertyName("bs")]
            public string Bs { get; set; }
            public override string ToString()
            {
                return @$"
    Name: {Name}
    CatchPhrase: {CatchPhrase}
    Bs: {Bs}";
            }
        }
        public class Geo
        {
            [JsonPropertyName("lat")]
            public string Lat { get; set; }
            [JsonPropertyName("lng")]
            public string Lng { get; set; }
            public override string ToString()
            {
                return @$"Lat: {Lat}
         Lng: {Lng}";
            }
        }

        public override string ToString()
        {
            return @$"Id: {Id} 
Name:{Name}
User Name:{Username}
Email:{Email}
Address:{Address.ToString()}
Phone: {Phone}{Website}
Website: {Website}
Company: {Company.ToString()}";
        }

    }
}

    

