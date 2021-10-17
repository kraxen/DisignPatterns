namespace StructuralPatterns.Composite
{
    public interface IComponent
    {
        public string Name { get; set; }
        public void Print();
    }
}
