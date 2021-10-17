namespace StructuralPatterns.Bridge
{
    public interface IProgrammer
    {
        public ILanguage Language { get; set; }
        
        public virtual void DoWork()
        {
            Language.Build();
            Language.Execute();
        }
        public abstract void EarnMoney();
    }
}
