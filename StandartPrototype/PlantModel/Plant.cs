using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartPrototype.PlantModel
{
    public abstract class Plant: ICloneable
    {
        public string Name;

        protected Plant(Plant plant)
        {
            Name = plant.Name;
        }

        public Plant()
        {
        }

        public abstract object Clone();
    }
}
