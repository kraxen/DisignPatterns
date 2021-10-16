using System;

namespace SOLID.Interface_Segregation_Principle.Example1
{
    public class SmsMessage : ITextMessage
    {
        public string Text { get; set; }
        public string FromAddress { get; set; }
        public string ToAddress { get; set; }
        public void Send()
        {
            Console.WriteLine("Отправляем по Sms сообщение: {0}", Text);
        }
    }
}
