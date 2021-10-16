using System;
using System.IO;

namespace SOLID.Single_Responsibility_Principle.Example1
{
    public class FileTxtPrinter : IPrinter
    {
        public void Print(string text)
        {
            using (StreamWriter sw = File.CreateText("print.txt"))
            {
                sw.WriteLine();
            }
            Console.WriteLine("Текст сохранен в файл print.txt");
        }
    }
}
