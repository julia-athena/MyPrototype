using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartPrototype.PlantModel
{
    public class Wood: ICloneable
    {
        public string WoodTexture;
        public string WoodColour;
        public bool WithThorns;

        public Wood() { }

        protected Wood(Wood wood)
        {
            WoodTexture = wood.WoodTexture;
            WoodColour = wood.WoodColour;
            WithThorns = wood.WithThorns;
        }
        public object Clone()
        {
            return new Wood(this);
        }
    }
}
