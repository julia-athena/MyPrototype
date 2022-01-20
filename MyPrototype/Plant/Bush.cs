using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public class Bush : WoodyPlant
    {
        public bool WithThorns;
        public Bush(string name, string woodType, string woodColour, bool withThorns) : base(name, woodType, woodColour)
        {
            WithThorns = withThorns;
        }
    }
}
