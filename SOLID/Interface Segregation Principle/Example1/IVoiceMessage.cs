namespace SOLID.Interface_Segregation_Principle.Example1
{
    public interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}
