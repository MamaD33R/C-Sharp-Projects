using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Math
    {
        public int Add(int x) // method overloading but passing in different types of parameters 
        {
            int result = x * 10;
            return result;
        }

        public int Add(decimal y)
        {
            int convert = Convert.ToInt32(y);
            int result2 = convert * 42;
            return result2;
        }

        public int Add(string i)
        {

            int convert = Convert.ToInt32(i);
            int result3 = convert * 3;
            return result3;
        }
    }
}
