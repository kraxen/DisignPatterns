using System;

namespace StructuralPatterns.Bridge
{
    public class FreelanceProgrammer : IProgrammer
    {
        public ILanguage Language { get; set; }
        public FreelanceProgrammer(ILanguage lang)
        {
            Language = lang;
        }
        public void EarnMoney()
        {
            Console.WriteLine("Получаем оплату за выполненный заказ");
        }
    }
}
