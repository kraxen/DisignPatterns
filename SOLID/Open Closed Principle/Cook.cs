using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Open_Closed_Principle
{
    public class Cook
    {
        public string Name { get; set; }

        public Cook(string name)
        {
            this.Name = name;
        }

        public void MakeDinner(IMeal meal)
        {
            meal.Make();
        }
    }
}
