using System;

namespace BehaviorPatterns.Command
{
    // Receiver - Получатель
    public class TV
    {

        public Volume volume;
        public TV() => volume = new Volume();
        public void On()
        {
            Console.WriteLine("Телевизор включен!");
        }

        public void Off()
        {
            Console.WriteLine("Телевизор выключен...");
        }
    }
}
