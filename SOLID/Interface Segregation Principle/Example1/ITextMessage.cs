namespace SOLID.Interface_Segregation_Principle.Example1
{
    public interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}
