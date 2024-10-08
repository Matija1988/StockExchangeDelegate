﻿using System;
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

        public delegate string AlertOwners (Stock stock, List<Owner> owners);

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
               startDate = startDate.AddDays(1);
            
                foreach (var stock in _dataInit._stocks)
                {
                    
                    double? previousValue = stock.ValueOverTime.Count > 0 ? stock.ValueOverTime.Peek().value : (double?)null;

                    double newValue = rand.Next(90, 120);
                    var stockInformation = new StockInformation(newValue, startDate);
                    stock.ValueOverTime.Enqueue(stockInformation);
                                     

                    Console.WriteLine($"NAME: {stock.Name} \tVALUE: {newValue}\tDATE: {startDate}");

                    if (previousValue.HasValue && newValue <= previousValue * 0.98)
                    {
                        Alert alertDelegate = stockAlert => $"ALERT: {stockAlert.Name} has dropped by 2% or more!";

                        var owners = _dataInit._owners.Where(x => x.Stocks.Contains(stock)).ToList();

                        Console.WriteLine(alertDelegate(stock));
                       
                        foreach (var owner in owners)
                        {
                            Console.WriteLine($"Sending notification to {owner.FirstName} {owner.LastName}");
                        }
                        loop = false;
                        break;

                    }

                }
            }
        }
    }
}
