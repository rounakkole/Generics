using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class FindMax
    {
        public int MaxInt(int Value1, int Value2, int Value3)
        {
            if (Value1.CompareTo(Value2) > 0 && Value1.CompareTo(Value3) > 0)
            { 
                return Value1; 
            }
            else if (Value2.CompareTo(Value1) > 0 && Value2.CompareTo(Value3) > 0)
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
