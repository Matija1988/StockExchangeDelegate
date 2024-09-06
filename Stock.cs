namespace StockExchangeDelegate
{
    public class Stock
    {
        public string Name { get; set; }
        public Queue<StockInformation> ValueOverTime { get; set; }


    }

    public record StockInformation(double value, DateOnly date);

}