using BehaviorPatterns.Observer.Example1;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class ObserverPattern : IPattern
    {
        public void Start()
        {

            Stock stock = new Stock();
            Bank bank = new Bank("ЮнитБанк", stock);
            Broker broker = new Broker("Иван Иваныч", stock);
            // имитация торгов
            for (int i = 0; i < 5; i++)
            {
                stock.Market();
            }
            Console.WriteLine();
            // брокер прекращает наблюдать за торгами
            broker.StopTrade();
            // имитация торгов
            for (int i = 0; i < 5; i++)
            {
                stock.Market();
            }

        }
    }
}
