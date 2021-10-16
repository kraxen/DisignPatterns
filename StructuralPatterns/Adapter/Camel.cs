using System;

namespace StructuralPatterns.Adapter
{
    // класс верблюда
    public class Camel : IAnimal
    {
        public void Move()
        {
            Console.WriteLine("Верблюд идет по пескам пустыни");
        }
    }
}
