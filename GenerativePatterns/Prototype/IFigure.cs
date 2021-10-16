namespace GenerativePatterns.Prototype
{
    public interface IFigure
    {
        IFigure Clone();
        void GetInfo();
        double GetArea();
    }
}
