using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartPrototype.PlantModel
{
    public class Fruit : ICloneable
    {
        public string FruitType;
        public int PlusToHealth;

        public Fruit()
        {
        }

        protected Fruit(Fruit fruit)
        {
            FruitType = fruit.FruitType;
            PlusToHealth = fruit.PlusToHealth;
        }

        public object Clone()
        {
            return new Fruit(this);
        }
    }
}
