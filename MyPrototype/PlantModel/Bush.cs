using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class Bush : WoodyPlant
    {
        public bool WithThorns;
        public IMyCloneable<Fruit> Fruit;

        public Bush()
        {
        }

        public Bush(Bush bush) : base(bush)
        {
            WithThorns = bush.WithThorns;
            Fruit = bush.Fruit;
        }

        public override Plant Clone()
        {
            var b = new Bush(this);
            b.Fruit = Fruit.Clone();
            return b;
        }
    }
}
