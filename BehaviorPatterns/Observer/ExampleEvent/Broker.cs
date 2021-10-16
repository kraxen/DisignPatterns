using System;

namespace BehaviorPatterns.Observer.ExampleEvent
{
    public class Broker : IBroker
    {
        public string Name { get; set; }

        Stock stock;
        public Broker(string name, Stock obs)
        {
            this.Name = name;
            stock = obs;
            stock.Nonity += Update;

        }
        public void Update(StockInfo ob)
        {
            StockInfo sInfo = (StockInfo)ob;

            if (sInfo.USD > 30)
                Console.WriteLine("Брокер {0} продает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
            else
                Console.WriteLine("Брокер {0} покупает доллары;  Курс доллара: {1}", this.Name, sInfo.USD);
        }
        public void StopTrade()
        {
            Console.WriteLine($"{this.Name} прекращает налюдать за торгами");
            stock.Nonity -= Update;
            stock = null;
        }
    }
}
