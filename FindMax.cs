using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax<T>
    {
        T Max;

        public void MaxValue(T[] ArrayValue)
        {
            Array.Sort(ArrayValue);
            Array.Reverse(ArrayValue);

             Max = ArrayValue[0];
        }


        public void toPrint()
        {
            Console.WriteLine($"maximum value: {Max}");
            
        }

    }
}
