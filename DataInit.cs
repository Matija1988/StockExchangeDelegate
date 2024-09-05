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


        private Main _main {  get; }
        public DataInit(Main main) : this()
        {
            this._main = main;
        }

        public DataInit()
        {
            this._stocks = new List<Stock>();
            FillStocks();
        }

        private void FillStocks()
        {
            var firstDate = new DateOnly(2023, 4, 5);
            var secondDate = new DateOnly(2023, 4, 6);
            var first = new StockInformation(100, firstDate);
            var second = new StockInformation(102, secondDate);

            var nvidiaStartDate = new DateOnly(2023, 4, 5);
            var nvidia2ndDate = new DateOnly(2023, 4, 6);

            var nvidia1st = new StockInformation(92, nvidiaStartDate);
            var nvidia2nd = new StockInformation(97, nvidia2ndDate);

            var stockQueue = new Queue<StockInformation>();
            var nvidiaQueue = new Queue<StockInformation>();
            stockQueue.Enqueue(first);
            nvidiaQueue.Enqueue(nvidia1st);
            stockQueue.Enqueue(second);
            nvidiaQueue.Enqueue(nvidia2nd);

            _stocks.Add(new Stock()
            {
                Name = "Intel",
                ValueOverTime = stockQueue

            });

            _stocks.Add(new Stock()
            {
                Name = "Nvidia",
                ValueOverTime = nvidiaQueue
            });

        }
    }
}
