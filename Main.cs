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

                foreach (var stock in _dataInit._stocks)
                {

                    double? previousValue = stock.ValueOverTime.Count > 0 ? stock.ValueOverTime.Peek().value : (double?)null;

                    double newValue = rand.Next(90, 120);
                    var stockInformation = new StockInformation(newValue, startDate);
                    stock.ValueOverTime.Enqueue(stockInformation);

                    Console.WriteLine($"NAME: {stock.Name} \tVALUE: {newValue}\tDATE: {startDate}");

                    foreach (var item in stock.ValueOverTime)
                    {
                        Console.WriteLine($"NAME: {stock.Name} \tVALUE: {item.value}\tDATE: {item.date}");

                    }

                    if (previousValue.HasValue && newValue <= previousValue * 0.98)
                    {
                        Alert alertDelegate = stockAlert => $"ALERT: {stockAlert.Name} has dropped by 2% or more!";
                        Console.WriteLine(alertDelegate(stock));
                        loop = false;
                        break;

                    }

                }
            }
        }
    }
}
