using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockExchangeDelegate
{
    public class StockAlert
    {
        

        public static Predicate<string?> _alertMessage;

        public static Stock _stock; 

        public static void RaiseAlert(double priceYesterday, double priceToday, DateOnly today)
        {
           

            int differencePercentage = (int)(priceToday / priceYesterday) * 100 ;

            var outputMsg = $"{today} \t WARNING!!! \t STOCK VALUE DROP!!!";

            if (differencePercentage >= 2)
            {
                _alertMessage(outputMsg);
            }
        }
    }
}
