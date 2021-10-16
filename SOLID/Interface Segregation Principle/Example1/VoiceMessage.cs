using System;

namespace SOLID.Interface_Segregation_Principle.Example1
{
    public class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; }
        public string FromAddress { get; set; }

        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine("Передача голосовой почты");
        }
    }
}
