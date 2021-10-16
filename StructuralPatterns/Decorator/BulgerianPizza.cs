namespace StructuralPatterns.Decorator
{
    public class BulgerianPizza : Pizza
    {
        public BulgerianPizza()
            : base("Болгарская пицца")
        { }
        public override int GetCost()
        {
            return 8;
        }
    }
}
