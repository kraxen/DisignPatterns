using System;

namespace SOLID.Single_Responsibility_Principle.Example1
{
    public class ConsolePageNavigation : IPageNavigation
    {
        public void GoToFirstPage()
        {
            Console.WriteLine("Переход к первой странице");
        }

        public void GoToLastPage()
        {
            Console.WriteLine("Переход к последней странице");
        }

        public void GoToPage(int pageNumber)
        {
            Console.WriteLine("Переход к странице {0}", pageNumber);
        }
    }
}