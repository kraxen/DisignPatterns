using System;

namespace SOLID.Interface_Segregation_Principle.Example2
{
    public class Camera : IPhoto
    {
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью фотокамеры");
        }
    }
}
