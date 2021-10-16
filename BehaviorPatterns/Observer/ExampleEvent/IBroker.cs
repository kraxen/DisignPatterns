namespace BehaviorPatterns.Observer.ExampleEvent
{
    public interface IBroker
    {
        void StopTrade();
        void Update(StockInfo ob);
    }
}