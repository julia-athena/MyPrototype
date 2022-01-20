using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public class Tree : WoodyPlant
    {
        public string CrownForm;
        public string CrownSize;
        public Tree(string name, string woodType, string woodColour, string crownForm, string crownSize) : base(name, woodType, woodColour)
        {
            CrownForm = crownForm;
            CrownSize = crownSize;
        }

        public override Plant Clone()
        {
            return new Tree(Name, WoodType, WoodColour, CrownForm, CrownSize);
        }
    }
}
