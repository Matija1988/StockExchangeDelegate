namespace StockExchangeDelegate
{
    public class Stock
    {
        public string Name { get; set; }
        public Queue<StockInformation> ValueOverTime { get; set; }

        public Stock(string name)
        {
            Name = name;
            ValueOverTime = new Queue<StockInformation>();
        }

    }

    public record StockInformation(double value, DateOnly date);

}