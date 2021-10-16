using BehaviorPatterns.Iterator;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class IteratorPattern : IPattern
    {
        public void Start()
        {
            AutoPark autoPark = new AutoPark();
            autoPark.Add(new Car { Model = "Volvo" });
            autoPark.Add(new Car { Model = "Audi" });
            autoPark.Add(new Car { Model = "BMW" });
            foreach (var car in autoPark)
            {
                Console.Write($"{car.Model} ");
            }

            Console.WriteLine();
        }
    }
}
