using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public abstract class Plant : IMyCloneable<Plant>
    {
        public string Name;

        public Plant(string name)
        {
            Name = name;
        }
        public Plant(Plant plant)
        {
            Name = plant.Name;
        }
        public abstract Plant Clone();
    }
}
