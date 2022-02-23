using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax<T>
    {
        public T MaxValue(T[] ArrayValue)
        {
            Array.Sort(ArrayValue);
            Array.Reverse(ArrayValue);

            return ArrayValue[0];
        }


    }
}
