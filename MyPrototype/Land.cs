using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyPrototype.PlantModel;

namespace MyPrototype
{
    public class Land
    {
        public List<IMyCloneable<Plant>> Plants = new List<IMyCloneable<Plant>>();
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
