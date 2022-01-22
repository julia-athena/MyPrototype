using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class Bush : WoodyPlant
    {
        public IMyCloneable<Fruit> Fruit;

        public Bush()
        {
        }

        protected Bush(Bush bush) : base(bush)
        {
            Fruit = bush.Fruit.Clone();
        }

        public override Plant Clone()
        {
            return new Bush(this);
        }
    }
}
