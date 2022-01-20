using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public class WoodyPlant: Plant
    {
        public string WoodType;
        public string WoodColour;

        public WoodyPlant(string name, string woodType, string woodColour) : base(name)
        {
            WoodType = woodType;
            WoodColour = woodColour;
        }

        public override Plant Clone()
        {
            return new WoodyPlant(Name, WoodType, WoodColour);
        }
    }
}
