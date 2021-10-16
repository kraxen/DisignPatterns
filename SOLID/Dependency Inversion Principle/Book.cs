using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Dependency_Inversion_Principle
{
    public class Book
    {
        public string Text { get; set; }
        public IPrinter Printer { get; set; }

        public Book(IPrinter printer)
        {
            this.Printer = printer;
        }

        public void Print()
        {
            Printer.Print(Text);
        }
    }
}
