using System;

namespace StructuralPatterns.Facade
{
    // текстовый редактор
    public class TextEditor
    {
        public void CreateCode()
        {
            Console.WriteLine("Написание кода");
        }
        public void Save()
        {
            Console.WriteLine("Сохранение кода");
        }
    }
}
