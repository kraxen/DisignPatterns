using StructuralPatterns.Composite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.StructuralPatterns
{
    class Composite : IPattern
    {
        public void Start()
        {
            IDirrectory fileSystem = new Directory() { Name= "Файловая система" };
            // определяем новый диск
            IDirrectory diskC = new Directory() { Name = "Диск С" };
            // новые файлы
            IComponent pngFile = new File() { Name = "12345.png" };
            IComponent docxFile = new File() { Name = "Document.docx" };
            // добавляем файлы на диск С
            diskC.Add(pngFile);
            diskC.Add(docxFile);
            // добавляем диск С в файловую систему
            fileSystem.Add(diskC);
            // выводим все данные
            fileSystem.Print();
            Console.WriteLine();
            // удаляем с диска С файл
            diskC.Remove(pngFile);
            // создаем новую папку
            IDirrectory docsFolder = new Directory() { Name="Мои Документы" };
            // добавляем в нее файлы
            IComponent txtFile = new File() { Name= "readme.txt" };
            IComponent csFile = new File() { Name = "Program.cs" };
            docsFolder.Add(txtFile);
            docsFolder.Add(csFile);
            diskC.Add(docsFolder);

            fileSystem.Print();
        }
    }
}
