using QuotesApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace QuotesApi.Controllers
{
    public class QuotesController : ApiController
    {
        static List<Quote> Quotes = new List<Quote>()
        {
            new Quote()
            {
                Id = 0,
                Author = "Einstein",
                Description = "Life is like riding a bicycle. To keep your balance you must keep moving.",
                Title = "Life Quote"
            },
             new Quote()
            {
                Id = 1,
                Author = "Walt Disney",
                Description = "All our dreams can come true, if we have the courage to pursue them.",
                Title = "Dreams Quote"
            }

        };

        public IEnumerable<Quote> Get()
        {
            return Quotes;
        }

        public void Post([FromBody]Quote quote)
        {
            Quotes.Add(quote);
        }

        public void Put(int id, [FromBody] Quote quote)
        {
            Quotes[id] =  quote;
        }

        public void Delete(int id)
        {
            Quotes.RemoveAt(id);
        }
    }
}
