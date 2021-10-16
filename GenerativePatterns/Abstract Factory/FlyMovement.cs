using System;

namespace GenerativePatterns.Abstract_Factory
{
    // движение полета
    public class FlyMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Летим");
        }
    }
}
