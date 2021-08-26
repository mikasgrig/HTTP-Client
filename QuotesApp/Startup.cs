using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp
{
    public class Startup
    {
        public IServiceProvider ConfigureServices()
        {
            var services = new ServiceCollection();
            services.AddTransient<HttpClient>();
            services.AddHttpClient<IQuoteClient, QuoteClient>(httpClient =>
            {
                httpClient.BaseAddress = new Uri("https://favqs.com/api/");
                httpClient.DefaultRequestHeaders.Add("Authorization", "Token token=43db73bd516a9ccba7917fe21bb8aded");
            });
            services.AddSingleton<QuoteApp>();
            return services.BuildServiceProvider();
        }
     }
}
