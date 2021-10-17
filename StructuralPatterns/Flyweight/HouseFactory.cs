using System.Collections.Generic;

namespace StructuralPatterns.Flyweight
{

    public enum HouseType
    {
        Panel,
        Brick
    }
    public class HouseFactory
    {
        Dictionary<HouseType, House> houses = new Dictionary<HouseType, House>();
        public HouseFactory()
        {
            houses.Add(HouseType.Panel, new PanelHouse());
            houses.Add(HouseType.Brick, new BrickHouse());
        }

        public House GetHouse(HouseType key)
        {
            if (houses.TryGetValue(key, out var house))
                return house;
            else throw new System.Exception("Нет дома с таким типом.");
        }
    }
}
