using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BehaviorPatterns.Visitor
{
    public class Company : IAccount
    {
        public string Name { get; set; }
        public string RegNumber { get; set; }
        public string Number { get; set; }

        public void Accept(IVisitor visitor)
        {
            visitor.VisitCompanyAc(this);
        }
    }
}
