using System;

namespace BehaviorPatterns.Chain_of_responsibility
{
    public class BankPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.BankTransfer == true)
                Console.WriteLine("Выполняем банковский перевод");
            else if (Successor != null)
                Successor.Handle(receiver);
            else Console.WriteLine("Перевод не удался");
        }
    }
}
