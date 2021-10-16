using SOLID.Interface_Segregation_Principle.Example2;
using System;

namespace PatternsStart.SOLID
{
    class InterfaceSegregationPrincipleE2 : IPattern
    {
        public void Start()
        {
            Photograph photograph = new Photograph();

            Camera camera = new Camera();
            Phone phone = new Phone();

            photograph.TakePhoto(camera);
            photograph.TakePhoto(phone);
        }
    }

}
