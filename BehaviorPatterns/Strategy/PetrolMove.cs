using System;

namespace BehaviorPatterns.Strategy
{
    public class PetrolMove : IMovable
    {
        public void Move()
        {
            Console.WriteLine("Перемещение на бензине");
        }
    }
}
