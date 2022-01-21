using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class WoodyPlant: Plant
    {
        public string WoodType;
        public string WoodColour;

        public WoodyPlant()
        {
        }

        public WoodyPlant(WoodyPlant woodyPlant) : base(woodyPlant)
        {
            WoodType = woodyPlant.WoodType;
            WoodColour = woodyPlant.WoodColour;
        }

        public override Plant Clone()
        {
            return new WoodyPlant(this);
        }
    }
}
