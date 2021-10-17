using StructuralPatterns.Facade;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.StructuralPatterns
{
    class Facade : IPattern
    {
        public void Start()
        {
            TextEditor textEditor = new TextEditor();
            Compiller compiller = new Compiller();
            CLR clr = new CLR();

            VisualStudioFacade ide = new VisualStudioFacade(textEditor, compiller, clr);

            Programmer programmer = new Programmer();
            programmer.CreateApplication(ide);
        }
    }
}
