using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class WoodyPlant: Plant
    {
        public IMyCloneable<Wood> Wood;

        public WoodyPlant()
        {
        }

        protected WoodyPlant(WoodyPlant woodyPlant) : base(woodyPlant)
        {
            Wood = woodyPlant.Wood.Clone();
        }

        public override Plant Clone()
        {
            return new WoodyPlant(this);
        }
    }
}
