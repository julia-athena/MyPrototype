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

        public Tree(Tree tree) : base(tree)
        {
            CrownType = tree.CrownType;
            CrownSize = tree.CrownSize;
            Fruit = tree.Fruit;
        }

        public override Plant Clone()
        {
            var t = new Tree(this);
            t.Fruit = Fruit.Clone();
            return t;
        }
    }
}
