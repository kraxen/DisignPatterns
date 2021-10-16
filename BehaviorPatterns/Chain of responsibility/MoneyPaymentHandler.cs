using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPatterns.Chain_of_responsibility
{
    // переводы с помощью системы денежных переводов
    public class MoneyPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.MoneyTransfer == true)
                Console.WriteLine("Выполняем перевод через системы денежных переводов");
            else if (Successor != null)
                Successor.Handle(receiver);
            else Console.WriteLine("Перевод не удался");
        }
    }
}
