using System;
using System.Collections.Generic;

namespace StructuralPatterns.Composite
{
    public class Directory : IComponent, IDirrectory
    {
        private List<IComponent> components;
        public string Name { get; set; }

        public Directory()
        {
            components = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            components.Add(component);
        }

        public void Remove(IComponent component)
        {
            components.Remove(component);
        }

        public void Print()
        {
            Console.WriteLine(Name?? "Без имени");
            components.ForEach(c => c.Print());
        }
    }
}
