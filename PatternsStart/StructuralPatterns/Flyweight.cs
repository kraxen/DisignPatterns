using StructuralPatterns.Flyweight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsStart.StructuralPatterns
{
    class Flyweight : IPattern
    {
        public void Start()
        {
            double longitude = 37.61;
            double latitude = 55.74;

            HouseFactory houseFactory = new HouseFactory();
            for (int i = 0; i < 5; i++)
            {
                House panelHouse = houseFactory.GetHouse(HouseType.Panel);
                panelHouse.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }

            for (int i = 0; i < 5; i++)
            {
                House brickHouse = houseFactory.GetHouse(HouseType.Brick);
                brickHouse?.Build(longitude, latitude);
                longitude += 0.1;
                latitude += 0.1;
            }
        }
    }
}
