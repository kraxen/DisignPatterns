using StructuralPatterns.Decorator;
using System;

namespace PatternsStart.StructuralPatterns
{
    class Decorator : IPattern
    {
        public void Start()
        {
            Pizza pizza1 = new TomatoPizza(new ItalianPizza()); // итальянская пицца с томатами
            Console.WriteLine("Название: {0}", pizza1.Name);
            Console.WriteLine("Цена: {0}", pizza1.GetCost());

            Pizza pizza2 = new CheesePizza(new ItalianPizza());// итальянская пиццы с сыром
            Console.WriteLine("Название: {0}", pizza2.Name);
            Console.WriteLine("Цена: {0}", pizza2.GetCost());

            Pizza pizza3 = new TomatoPizza(new BulgerianPizza());
            pizza3 = new CheesePizza(pizza3);// болгарская пиццы с томатами и сыром
            Console.WriteLine("Название: {0}", pizza3.Name);
            Console.WriteLine("Цена: {0}", pizza3.GetCost());
        }
    }
}
