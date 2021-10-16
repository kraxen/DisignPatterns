using System;

namespace BehaviorPatterns.Mediator
{
    // класс тестера
    public class TesterColleague : IColleague
    {
        public IMediator Mediator { get; init; }
        public void Send(string message)
        {
            Mediator.Send(message, this);
        }
        public void Notify(string message)
        {
            Console.WriteLine("Сообщение тестеру: " + message);
        }
    }
}
