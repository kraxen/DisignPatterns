using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Composite
{
    public class File : IComponent
    {
        public string Name { get; set; }
        public void Print() => Console.WriteLine(Name ?? "Без имени");
    }
}
