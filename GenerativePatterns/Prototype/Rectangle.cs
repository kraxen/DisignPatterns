using System;

namespace GenerativePatterns.Prototype
{
    public class Rectangle : IFigure
    {
        int width;
        int height;
        public Rectangle(int w, int h)
        {
            width = w;
            height = h;
        }

        public IFigure Clone()
        {
            return new Rectangle(this.width, this.height);
        }
        public void GetInfo()
        {
            Console.WriteLine("Прямоугольник длиной {0} и шириной {1}, площадью {2}", height, width, GetArea());
        }
        public double GetArea()
        {
            return width * height;
        }
    }
}
