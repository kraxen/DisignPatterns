namespace BehaviorPatterns.Mediator
{
    public interface IMediator
    {
        public abstract void Send(string msg, IColleague colleague);
    }
}
