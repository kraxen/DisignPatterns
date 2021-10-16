using System;

namespace BehaviorPatterns.Observer.ExampleEvent
{
    public interface IStock
    {
        Action<StockInfo> Nonity { get; set; }

        void Market();
    }
}