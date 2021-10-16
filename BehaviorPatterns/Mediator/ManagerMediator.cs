namespace BehaviorPatterns.Mediator
{
    public class ManagerMediator : IMediator
    {
        public IColleague Customer { get; set; }
        public IColleague Programmer { get; set; }
        public IColleague Tester { get; set; }
        public void Send(string msg, IColleague colleague)
        {
            // если отправитель - заказчик, значит есть новый заказ
            // отправляем сообщение программисту - выполнить заказ
            if (Customer == colleague)
                Programmer.Notify(msg);
            // если отправитель - программист, то можно приступать к тестированию
            // отправляем сообщение тестеру
            else if (Programmer == colleague)
                Tester.Notify(msg);
            // если отправитель - тест, значит продукт готов
            // отправляем сообщение заказчику
            else if (Tester == colleague)
                Customer.Notify(msg);
        }
    }
}
