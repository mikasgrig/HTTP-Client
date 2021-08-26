using QuotesApp.Modals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuotesApp
{
    public interface IQuoteClient
    {
        Task<QuotesModal> GetAllQuotes();
        Task<QuoteModal> GetQuote(int quoteId);
        Task<QuoteModal> AddQuote(QuoteWriteModal quote, string token);
        Task<QuoteModal> FavQuote(int quoteId, string token);
        Task<QuoteUserSesionModal> CreatSession(QuoteUserModal user);
        Task<string> DestroySession(string token);
        Task<string> DeleteQuote(int quoteId, string token);
    }
}
