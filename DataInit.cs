using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeDelegate
{
    public class DataInit
    {
        public List<Stock> _stocks { get; set; }

        public List<Owner> _owners { get; set; }

        private Main _main { get; }
        public DataInit (Main main) : this()
        {
            this._main = main;
        }

        public DataInit ()
        {
            _stocks = new List<Stock>()
        {
            new Stock("Intel"),
            new Stock("Apple"),
            new Stock("Google")
        };

            List<Stock> owner1Stock = new List<Stock>();
            owner1Stock.Add(_stocks[0]);
            owner1Stock.Add(_stocks[2]);

            List<Stock> owner2Stock = new List<Stock>();
            owner2Stock.Add(_stocks[1]);
            owner2Stock.Add(_stocks[2]);

            List<Stock> owner3Stock = new List<Stock>();
            owner3Stock.Add(_stocks[0]);
            owner3Stock.Add(_stocks[1]);

            _owners = new List<Owner>()
            {
                new Owner("Bob", "Bobby", owner1Stock),
                new Owner("Ivan", "Grozny", owner2Stock),
                new Owner("Tim", "Timmy",owner3Stock)
            };

        }


    }
}
