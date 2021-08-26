using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using QuotesApp.Modals;

namespace QuotesApp
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var startup = new Startup();
            var serviceProvider = startup.ConfigureServices();
            var quotesApp = serviceProvider.GetService<QuoteApp>();
            await quotesApp.StartAsync();
        }
    }
}
