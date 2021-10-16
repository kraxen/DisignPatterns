using System;

namespace SOLID.Single_Responsibility_Principle.Example1
{
    public class ConsolePrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }
    }
}
