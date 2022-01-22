using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype.PlantModel
{
    public class Tree : WoodyPlant
    {
        public string CrownType;
        public string CrownSize;
        public IMyCloneable<Fruit> Fruit;

        public Tree()
        {
        }

        protected Tree(Tree tree) : base(tree)
        {
            CrownType = tree.CrownType;
            CrownSize = tree.CrownSize;
            Fruit = tree.Fruit.Clone();
        }

        public override Plant Clone()
        {
            return new Tree(this);
        }
    }
}
