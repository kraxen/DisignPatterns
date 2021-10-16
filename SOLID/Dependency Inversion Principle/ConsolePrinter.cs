using System;

namespace SOLID.Dependency_Inversion_Principle
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать на консоли");
        }
    }
}
