using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public abstract class Plant: IMyCloneable<Plant>
    {
        public string Name;

        public Plant(Plant plant)
        {
            Name = plant.Name;
        }

        public Plant()
        {
        }

        public abstract Plant Clone();
    }
}
