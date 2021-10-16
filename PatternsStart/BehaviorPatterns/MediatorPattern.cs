using BehaviorPatterns.Mediator;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class MediatorPattern : IPattern
    {
        public void Start()
        {
            ManagerMediator company = new ManagerMediator();

            IColleague customer = new CustomerColleague() { Mediator = company };
            IColleague programmer = new ProgrammerColleague() { Mediator = company };
            IColleague tester = new TesterColleague() { Mediator = company };

            company.Customer = customer;
            company.Programmer = programmer;
            company.Tester = tester;

            customer.Send("Есть заказ, надо сделать программу");
            programmer.Send("Программа готова, надо протестировать");
            tester.Send("Программа протестирована и готова к продаже");

        }
    }
}
