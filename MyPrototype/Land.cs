using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public class Land
    {
        public List<Plant> Plants = new List<Plant>();
        public Land()
        {

        }

        public void AddPlantByPrototype(string name, IMyCloneable<Plant> prototype)
        {
            var plant = prototype.Clone();
            plant.Name = name;
            Plants.Add(plant);
        }
    }
}
