using SOLID.Dependency_Inversion_Principle;
using System;

namespace PatternsStart.SOLID
{
    class DependencyInversionPrinciple : IPattern
    {
        public void Start()
        {
            Book book = new Book(new ConsolePrinter());
            book.Print();
            book.Printer = new HtmlPrinter();
            book.Print();
        }
    }

}
