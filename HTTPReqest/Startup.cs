using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace HTTPReqest
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<HttpClient>();
            services.AddHttpClient<IGithubClient, GithubClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://api.github.com");
            });

            services.AddHttpClient<IJsonPlaceholderClient, JsonplaceholderClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://jsonplaceholder.typicode.com");
            });

            return services.BuildServiceProvider();

        }
    }
}
