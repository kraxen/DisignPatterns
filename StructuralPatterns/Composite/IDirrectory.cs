namespace StructuralPatterns.Composite
{
    public interface IDirrectory : IComponent
    {
        public void Add(IComponent component);

        public void Remove(IComponent component);
    }
}
