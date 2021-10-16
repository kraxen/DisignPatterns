using System;

namespace GenerativePatterns.Prototype
{
    public class Square : IFigure
    {
        int lenght;
        public Square(int lenght)
        {
            this.lenght = lenght;
        }
        public IFigure Clone()
        {
            return new Square(this.lenght);
        }
        public void GetInfo()
        {
            Console.WriteLine("Квадрат со сторонами длиной {0}, площадью {1}", lenght, GetArea());
        }
        public double GetArea()
        {
            return lenght * lenght;
        }
    }
}
