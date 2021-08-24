using System;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;

namespace HTTPReqest
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startup = new Startup();

            var serviceProvider = startup.ConfigureServices();

            var githubClient = serviceProvider.GetService<IGithubClient>();
            var jsonplaceholderClient = serviceProvider.GetService<IJsonPlaceholderClient>();

            var mikasgrig = await githubClient.GetUser("mikasgrig");

            var users = await jsonplaceholderClient.GetUsers();

            var user = await jsonplaceholderClient.GetUser(1);
            var todos = await jsonplaceholderClient.GetTodoItems(2);
            var todosComplet = await jsonplaceholderClient.GetTodosByStatus(2, false);
            foreach (var item in todosComplet)
            {
                Console.WriteLine(item);
            }
        }
    }
}
