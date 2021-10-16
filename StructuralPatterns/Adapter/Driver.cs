namespace StructuralPatterns.Adapter
{
    public class Driver
    {
        public void Travel(ITransport transport)
        {
            transport.Drive();
        }
    }
}
