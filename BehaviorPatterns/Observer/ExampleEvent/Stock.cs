using System;

namespace BehaviorPatterns.Observer.ExampleEvent
{
    public class Stock : IStock
    {
        StockInfo sInfo; // информация о торгах
        public Action<StockInfo> Nonity { get; set; }

        public Stock()
        {
            sInfo = new StockInfo();
        }

        public void Market()
        {
            Random rnd = new Random();
            sInfo.USD = rnd.Next(20, 40);
            sInfo.Euro = rnd.Next(30, 50);
            Nonity?.Invoke(sInfo);
        }
    }
}
