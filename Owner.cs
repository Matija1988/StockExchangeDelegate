using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeDelegate
{
    public class Owner
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public List<Stock> Stocks { get; set; }

        public Owner(string firstName, string lastName, List<Stock> stocks)
        {
            Id = Guid.NewGuid();
            FirstName = firstName;
            LastName = lastName;
            Stocks = stocks;
        }
    }
}
