using System;

namespace GenerativePatterns.Abstract_Factory
{
    // движение - бег
    public class RunMovement : Movement
    {
        public override void Move()
        {
            Console.WriteLine("Бежим");
        }
    }
}
