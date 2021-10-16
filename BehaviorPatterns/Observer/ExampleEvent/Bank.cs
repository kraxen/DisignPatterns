using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPatterns.Observer.ExampleEvent
{
    public class Bank : IBroker
    {
        public string Name { get; set; }
        Stock stock;
        public Bank(string name, Stock obs)
        {
            this.Name = name;
            stock = obs;
            stock.Nonity += Update;
        }
        public void Update(StockInfo sInfo)
        {
            if (sInfo.Euro > 40)
                Console.WriteLine("Банк {0} продает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
            else
                Console.WriteLine("Банк {0} покупает евро;  Курс евро: {1}", this.Name, sInfo.Euro);
        }
        public void StopTrade()
        {
            Console.WriteLine($"{this.Name} прекращает налюдать за торгами");
            stock.Nonity -= Update;
            stock = null;
        }
    }
}
