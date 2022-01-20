using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public interface IMyCloneable<T>
    {
        public T Clone();
    }
}
