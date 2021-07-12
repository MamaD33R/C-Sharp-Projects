using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Math
    {
        public static void Add(int x) // method overloading but passing in different types of parameters 
        {
            Console.WriteLine(x * 10);
        }

        public static void Add(decimal y)
        {
            Console.WriteLine(y * 42);
        }

        public static void Add(string i)
        {
            Console.WriteLine(i + 5);
        }
    }
}
