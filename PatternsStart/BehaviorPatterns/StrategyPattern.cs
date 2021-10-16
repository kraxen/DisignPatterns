using BehaviorPatterns.Strategy;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class StrategyPattern : IPattern
    {
        public void Start()
        {

            Car auto = new Car(4, "Volvo");
            auto.Move(new PetrolMove());
            auto.Move(new ElectricMove());

        }
    }
}
