using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax
    {
        public T MaxValue<T>(T Value1, T Value2, T Value3)
        {
            if (Comparer<T>.Default.Compare(Value1,Value2)> 0 && Comparer<T>.Default.Compare(Value1, Value2) > 0)
            { 
                return Value1; 
            }
            else if (Comparer<T>.Default.Compare(Value2, Value1) > 0 && Comparer<T>.Default.Compare(Value2, Value3) > 0)
            {
                return Value2;
            }
            else
            {
                return Value3;
            }
        }


    }
}
