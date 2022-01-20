using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public class ConiferTree : Tree
    {
         
        public ConiferTree(string name, string woodType, string woodColour, string crownForm, string crownSize) : base(name, woodType, woodColour, crownForm, crownSize)
        {
        }
    }
}
