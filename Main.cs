using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeDelegate
{
    public class Main
    {
        public delegate string Alert (Stock stock);

        public DataInit _dataInit { get; }
        public Main ()
        {
            _dataInit = new DataInit(this);

        }

        public void StockMarket ()
        {
            var startDate = new DateOnly(2023, 5, 6);
            bool loop = true;
            Random rand = new Random();
            while (loop)
            {
                startDate.AddDays(1);
                double stockValue = rand.Next(90, 120);

                var stockInformation = new StockInformation(stockValue, startDate);

                

                foreach (var stock in _dataInit._stocks)
                {

                    foreach (var item in stock.ValueOverTime)
                    {
                        Console.WriteLine($"NAME: {stock.Name} \tVALUE: {item.value}\tDATE: {item.date}");

                    }
                 
                }

            }
        }
    }
}
