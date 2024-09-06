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
        }


    }
}
