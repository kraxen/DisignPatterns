using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Facade
{
    public class Programmer
    {
        public void CreateApplication(VisualStudioFacade facade)
        {
            facade.Start();
            facade.Stop();
        }
    }
}
