using System;

namespace SOLID.Open_Closed_Principle
{
    public class PotatoMeal : IMeal
    {
        public void Make()
        {
            Console.WriteLine("Чистим картошку");
            Console.WriteLine("Ставим почищенную картошку на огонь");
            Console.WriteLine("Сливаем остатки воды, разминаем варенный картофель в пюре");
            Console.WriteLine("Посыпаем пюре специями и зеленью");
            Console.WriteLine("Картофельное пюре готово");
        }
    }
}
