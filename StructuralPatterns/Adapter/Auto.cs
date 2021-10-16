using System;

namespace StructuralPatterns.Adapter
{
    // класс машины
    public class Auto : ITransport
    {
        public void Drive()
        {
            Console.WriteLine("Машина едет по дороге");
        }
    }
}
