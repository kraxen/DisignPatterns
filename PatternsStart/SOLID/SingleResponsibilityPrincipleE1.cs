using SOLID.Single_Responsibility_Principle.Example1;
using System;

namespace PatternsStart.SOLID
{
    class SingleResponsibilityPrincipleE1 : IPattern
    {
        public void Start()
        {
            Report report = new Report();

            report.PageNavigation = new ConsolePageNavigation();

            report.GoToFirstPage();
            report.GoToLastPage();
            report.GoToPage(15);

            report.Print(new FileTxtPrinter());
            report.Print(new ConsolePrinter());
        }
    }

}
