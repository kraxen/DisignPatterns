using System;

namespace BehaviorPatterns.Chain_of_responsibility
{
    public class PayPalPaymentHandler : PaymentHandler
    {
        public override void Handle(Receiver receiver)
        {
            if (receiver.PayPalTransfer == true)
                Console.WriteLine("Выполняем перевод через PayPal");
            else if (Successor != null)
                Successor.Handle(receiver);
            else Console.WriteLine("Перевод не удался");
        }
    }
}
