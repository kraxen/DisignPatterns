using System;

namespace SOLID.Dependency_Inversion_Principle
{
    public class HtmlPrinter : IPrinter
    {
        public void Print(string text)
        {
            Console.WriteLine("Печать в html");
        }
    }
}
