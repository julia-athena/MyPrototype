using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyPrototype
{
    public interface IMyCloneable<T> where T: IMyCloneable<T> // ограничиваем T, так чтобы он реалиовывал интерфейс IMyCloneable<T>
    {
        public T Clone();
    }
}
