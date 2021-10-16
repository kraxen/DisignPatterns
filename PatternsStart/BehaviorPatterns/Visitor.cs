using BehaviorPatterns.Visitor;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class Visitor : IPattern
    {
        public void Start()
        {

            var structure = new Bank();
            structure.Add(new Person { Name = "Иван Алексеев", Number = "82184931" });
            structure.Add(new Company { Name = "Microsoft", RegNumber = "ewuir32141324", Number = "3424131445" });
            structure.Accept(new HtmlVisitor());
            structure.Accept(new XmlVisitor());

        }
    }
}
