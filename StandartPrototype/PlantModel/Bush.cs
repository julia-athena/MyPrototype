using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StandartPrototype.PlantModel
{
    public class Bush : WoodyPlant
    {
        public Fruit Fruit;

        public Bush()
        {
        }

        protected Bush(Bush bush) : base(bush)
        {
            Fruit = (Fruit)bush.Fruit.Clone();
        }

        public override Plant Clone()
        {
            return new Bush(this);
        }
    }
}
