using QuotesApp.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp
{
    public class QuoteApp
    {
        private readonly IQuoteClient _quoteClient;

        public QuoteApp(IQuoteClient quoteClient)
        {
            _quoteClient = quoteClient;
        }

        public async Task StartAsync()
        {
            string newLogin;
            string newPasword;
            while (true)
            {
                Console.WriteLine("1 - Login");
                Console.WriteLine("2 - Exit");
                var choose = (Console.ReadLine());
                switch (choose)
                {
                    case "1":
                        Console.WriteLine("Enter login");
                        newLogin = (Console.ReadLine());
                        Console.WriteLine("Enter pasword");
                        newPasword = (Console.ReadLine());
                        var session = await _quoteClient.CreatSession(new QuoteUserModal { UserNew = new QuoteUserModal.User { Login = "mikasgrig", Password = "p3vU4Eq@LL4iFmE" } });
                        Console.WriteLine(session);
                        int chooseInt;
                        string newAuthot;
                        string newBody;
                        while (true)
                        {
                            Console.WriteLine("Command:");
                            Console.WriteLine("1 - Show all quotes");
                            Console.WriteLine("2 - Get quote");
                            Console.WriteLine("3 - Add quote");
                            Console.WriteLine("4 - Fav quote");
                            Console.WriteLine("5 - Delete quote");
                            Console.WriteLine("6 - Exit");
                            choose = (Console.ReadLine());
                            switch (choose)
                            {
                                case "1":
                                    var quotes = await _quoteClient.GetAllQuotes();
                                    foreach (var item in quotes.Qoutes)
                                    {
                                        Console.WriteLine(item);
                                    }
                                    break;
                                case "2":
                                    Console.WriteLine("Enter quote Id: ");
                                    chooseInt = Convert.ToInt32(Console.ReadLine());
                                    var quote = await _quoteClient.GetQuote(chooseInt);
                                    Console.WriteLine(quote);
                                    break;
                                case "3":
                                    Console.WriteLine("Enter new quote Author: ");
                                    newAuthot = (Console.ReadLine());
                                    Console.WriteLine("Enter new quote Body: ");
                                    newBody = (Console.ReadLine());
                                    var newQuote = await _quoteClient.AddQuote(new QuoteWriteModal { QuoteNew = new QuoteWriteModal.Quote { Author = newAuthot, Body = newBody } }, session.UserToken);
                                    Console.WriteLine(newQuote);
                                    break;
                                case "4":
                                    Console.WriteLine("Enter quote Id: ");
                                    chooseInt = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine(await _quoteClient.FavQuote(chooseInt, session.UserToken));
                                    break;
                                case "5":
                                    Console.WriteLine("Enter quote Id: ");
                                    chooseInt = Convert.ToInt32(Console.ReadLine());
                                    var message1 = await _quoteClient.DeleteQuote(chooseInt, session.UserToken);
                                    Console.WriteLine(message1);
                                    break;
                                case "6":
                                    var message = await _quoteClient.DestroySession(session.UserToken);
                                    Console.WriteLine(message);
                                    return;
                            }
                        }
                    case "2":
                        return;
                }
            }
        }
    }
}
