using BehaviorPatterns.State;
using System;

namespace PatternsStart.BehaviorPatterns
{
    class StateDIPattern : IPattern
    {
        public void Start()
        {

            Water water = new Water(new LiquidWaterState());
            water.Heat();
            water.Frost();
            water.Frost();

        }
    }
}
