using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Single_Responsibility_Principle.Example1
{
    public class Report
    {
        public string Text { get; set; }

        public IPageNavigation PageNavigation { get; set; }

        public void GoToFirstPage()
        {
            PageNavigation.GoToFirstPage();
        }

        public void GoToLastPage()
        {
            PageNavigation.GoToLastPage();
        }

        public void GoToPage(int pageNumber)
        {
            PageNavigation.GoToPage(pageNumber);
        }
        public void Print(IPrinter printer)
        {
            printer.Print(this.Text);
        }
    }
}
