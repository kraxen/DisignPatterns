using System;
using BehaviorPatterns.Chain_of_responsibility;

namespace PatternsStart.BehaviorPatterns
{
    class ChainOfResponsibilityPattern : IPattern
    {
        public void Start()
        {
            Receiver receiver = new Receiver(true, false, false);

            PaymentHandler bankPaymentHandler = new BankPaymentHandler();
            PaymentHandler moneyPaymentHadler = new MoneyPaymentHandler();
            PaymentHandler paypalPaymentHandler = new PayPalPaymentHandler();
            bankPaymentHandler.Successor = paypalPaymentHandler;
            paypalPaymentHandler.Successor = moneyPaymentHadler;

            bankPaymentHandler.Handle(receiver);
        }
    }
}
