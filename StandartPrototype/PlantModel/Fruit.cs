using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class Fruit : IMyCloneable<Fruit>
    {
        public string FruitType;
        public int PlusToHealth;

        public Fruit()
        {
        }

        public Fruit(Fruit fruit)
        {
            FruitType = fruit.FruitType;
            PlusToHealth = fruit.PlusToHealth;
        }

        public Fruit Clone()
        {
            return new Fruit(this);
        }
    }
}
