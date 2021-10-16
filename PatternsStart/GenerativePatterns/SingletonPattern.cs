using GenerativePatterns.Singleton;
using System;
using System.Threading;

namespace PatternsStart.GenerativePatterns
{
    class SingletonPattern : IPattern
    {
        public void Start()
        {
            (new Thread(() =>
            {
                Computer comp2 = new Computer();
                comp2.OS = OS.getInstance("Windows 10");
                Console.WriteLine(comp2.OS.Name);

            })).Start();

            Computer comp = new Computer();
            comp.Launch("Windows 8.1");
            Console.WriteLine(comp.OS.Name);
            Thread.Sleep(100);
        }
    }
    
}
