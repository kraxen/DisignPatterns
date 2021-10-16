namespace SOLID.Interface_Segregation_Principle.Example2
{
    public class Photograph
    {
        public void TakePhoto(IPhoto photoMaker)
        {
            photoMaker.TakePhoto();
        }
    }
}
