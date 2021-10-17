using System;

namespace StructuralPatterns.Bridge
{
    public class CorporateProgrammer : IProgrammer
    {
        public ILanguage Language { get; set; }
        public CorporateProgrammer(ILanguage lang)
        {
            Language = lang;
        }
        public void EarnMoney()
        {
            Console.WriteLine("Получаем в конце месяца зарплату");
        }
    }
}
