namespace GenerativePatterns.Factory_Method
{
    // абстрактный класс строительной компании
    public abstract class Developer
    {
        public string Name { get; set; }

        public Developer(string n)
        {
            Name = n;
        }
        // фабричный метод
        abstract public House Create();
    }
}
