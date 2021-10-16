using System;

namespace GenerativePatterns.Abstract_Factory
{
    // класс меч
    public class Sword : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Бьем мечом");
        }
    }
}
