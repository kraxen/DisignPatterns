using GenerativePatterns.Prototype;
using System;

namespace PatternsStart.GenerativePatterns
{
    class PrototypePattern : IPattern
    {
        public void Start()
        {
            IFigure figure = new Rectangle(30, 40);
            IFigure clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Circle(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();

            figure = new Square(30);
            clonedFigure = figure.Clone();
            figure.GetInfo();
            clonedFigure.GetInfo();
        }
    }
    
}
