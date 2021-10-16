using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructuralPatterns.Decorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza p)
            : base(p.Name + ", с сыром", p)
        { }

        public override int GetCost()
        {
            return pizza.GetCost() + 5;
        }
    }
}
