namespace BehaviorPatterns.Mediator
{
    public interface IColleague
    {
        public IMediator Mediator {get; init; }
        void Send(string message);
        void Notify(string message);
    }
}
