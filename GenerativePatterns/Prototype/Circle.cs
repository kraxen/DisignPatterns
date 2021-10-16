using System;

namespace GenerativePatterns.Prototype
{
    public class Circle : IFigure
    {
        int radius;
        public Circle(int r)
        {
            radius = r;
        }

        public IFigure Clone()
        {
            return new Circle(this.radius);
        }
        public void GetInfo()
        {
            Console.WriteLine("Круг радиусом {0}, плозадью {1}", radius, GetArea());
        }
        public double GetArea()
        {
            return Math.PI * radius * radius;
        }
    }
}
