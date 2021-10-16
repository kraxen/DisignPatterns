namespace SOLID.Interface_Segregation_Principle.Example1
{
    public interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
