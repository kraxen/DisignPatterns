using PatternsStart.BehaviorPatterns;
using PatternsStart.GenerativePatterns;
using PatternsStart.SOLID;
using PatternsStart.StructuralPatterns;
using System;
using System.Collections.Generic;

namespace PatternsStart
{
    class Program
    {
        static void Main(string[] args)
        {
            Show("Structural Patterns", new List<IPattern>
            {
                new Decorator(),
                new Adapter()
            });

            Show("Behavior Patterns", new List<IPattern>
            {
                new StrategyPattern(),
                new ObserverPattern(),
                new ObserverEventPattern(),
                new CommandPattern(),
                new TemplateMethodPattern(),
                new IteratorPattern(),
                new StateDIPattern(),
                new ChainOfResponsibilityPattern(),
                new MediatorPattern(),
                new Memento(),
                new Visitor()
            });

            Show("Generative Patterns", new List<IPattern>
            {
                new PrototypePattern(),
                new AbstractFactoryPattern(),
                new BuilderPattern(),
                new FactoryMethodPattern(),
                new SingletonPattern()
            });

            Show("SOLID", new List<IPattern>
            {
                new SingleResponsibilityPrincipleE1(),
                new SingleResponsibilityPrincipleE2(),
                new OpenClosedPrinciple(),
                new InterfaceSegregationPrincipleE1(),
                new InterfaceSegregationPrincipleE2(),
                new DependencyInversionPrinciple()
            });
        }

        public static void Show(string name, List<IPattern> patterns)
        {
            Console.WriteLine($"{name}:\n");
            {
                patterns.ForEach(p =>
                {
                    Console.WriteLine(p.GetType().Name);
                    p.Start();
                    Console.WriteLine();
                });
            }
            Console.ReadKey();
            Console.Clear();
        }
    }
}
