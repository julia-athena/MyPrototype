using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class Wood: IMyCloneable<Wood>
    {
        public string WoodTexture;
        public string WoodColour;
        public bool WithThorns;

        public Wood Clone()
        {
            throw new NotImplementedException();
        }
    }
}
