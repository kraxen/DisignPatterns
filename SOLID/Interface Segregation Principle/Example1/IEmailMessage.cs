namespace SOLID.Interface_Segregation_Principle.Example1
{
    public interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
}
