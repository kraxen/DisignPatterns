using GenerativePatterns.Abstract_Factory;
using System;

namespace PatternsStart.GenerativePatterns
{
    class AbstractFactoryPattern : IPattern
    {
        public void Start()
        {
            Hero elf = new Hero(new ElfFactory());
            elf.Hit();
            elf.Run();

            Hero voin = new Hero(new WariorFactory());
            voin.Hit();
            voin.Run();
        }
    }
    
}
