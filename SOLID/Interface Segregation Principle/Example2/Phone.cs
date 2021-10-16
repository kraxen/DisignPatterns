using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Interface_Segregation_Principle.Example2
{
    public class Phone : ICall, IPhoto, IVideo, IWeb
    {
        public void Call()
        {
            Console.WriteLine("Звоним");
        }
        public void TakePhoto()
        {
            Console.WriteLine("Фотографируем с помощью смартфона");
        }
        public void MakeVideo()
        {
            Console.WriteLine("Снимаем видео");
        }
        public void BrowseInternet()
        {
            Console.WriteLine("Серфим в интернете");
        }
    }
}
