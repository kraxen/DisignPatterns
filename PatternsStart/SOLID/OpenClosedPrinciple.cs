using SOLID.Open_Closed_Principle;
using System;

namespace PatternsStart.SOLID
{
    class OpenClosedPrinciple : IPattern
    {
        public void Start()
        {
            Cook cook = new Cook("Петр");

            cook.MakeDinner(new PotatoMeal());
            cook.MakeDinner(new SaladMeal());
        }
    }

}
