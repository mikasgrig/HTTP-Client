using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Work
{
    class Program
    {
        static async Task Main(string[] args)
        {
            
            var httpClient = new HttpClient();
            var httpUriUser = "https://jsonplaceholder.typicode.com/users";
            var userList = await httpClient.GetFromJsonAsync<List<User>>(httpUriUser);
            foreach (var item in userList)
            {
                Console.WriteLine(item.ToString());
            }
            Console.WriteLine("Press User Id");
            var input = Convert.ToInt32(Console.ReadLine());
            string todo1;
            Console.WriteLine("1 Done or 2 not done");
            var todo = Convert.ToInt32(Console.ReadLine());
            if (todo == 1)
            {
                todo1 = "true";
            }
            else
            {
                todo1 = "false";
            }
            var httpUriTodo = $"https://jsonplaceholder.typicode.com/todos?userId={input}&completed={todo1} ";
            
            var todoList = await httpClient.GetFromJsonAsync<List<Todos>>(httpUriTodo);
            
            foreach (var item in todoList) Console.WriteLine(item.ToString());

        }
    }
    class User
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
    Zipcode: {Zipcode}";
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
            public string lat { get; set; }
            public string lng { get; set; }
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
    class Todos
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
