namespace GenerativePatterns.Factory_Method
{
    // строит деревянные дома
    public class WoodDeveloper : Developer
    {
        public WoodDeveloper(string n) : base(n)
        { }

        public override House Create()
        {
            return new WoodHouse();
        }
    }
}
