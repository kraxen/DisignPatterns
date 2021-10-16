using System;

namespace GenerativePatterns.Abstract_Factory
{
    // класс арбалет
    public class Arbalet : Weapon
    {
        public override void Hit()
        {
            Console.WriteLine("Стреляем из арбалета");
        }
    }
}
