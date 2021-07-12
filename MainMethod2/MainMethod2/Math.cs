using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod2
{
    class Math
    {
        public static void Add(int x, int y = 0 )
        {
            Console.WriteLine("These numbers multiplied make: " + x * y);
        }

        public static void Add(int x)
        {
            Console.WriteLine("Your number is: " + x);
        }

    }
}
