namespace SOLID.Single_Responsibility_Principle.Example2
{
    public class TextPhoneSaver : IPhoneSaver
    {
        public void Save(Phone phone, string fileName)
        {
            using (System.IO.StreamWriter writer = new System.IO.StreamWriter(fileName, true))
            {
                writer.WriteLine(phone.Model);
                writer.WriteLine(phone.Price);
            }
        }
    }
}
