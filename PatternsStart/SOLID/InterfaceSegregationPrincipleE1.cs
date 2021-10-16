using SOLID.Interface_Segregation_Principle.Example1;
using System;
using System.Collections.Generic;

namespace PatternsStart.SOLID
{
    class InterfaceSegregationPrincipleE1 : IPattern
    {
        public void Start()
        {
            var messages = new List<IMessage>
             {
                 new EmailMessage(),
                 new SmsMessage(),
                 new VoiceMessage()
             };
            messages.ForEach(m => m.Send());
        }
    }

}
