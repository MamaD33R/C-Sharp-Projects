using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    public class Math
    {
        public static void Addition(int i)
        {
            Console.WriteLine(i + 100);
        }

        public static void Multi(int i)
        {
            Console.WriteLine("Your number multiplied by 40: \n" + i * 40);
        }

        public static void Divi(int i)
        {
            Console.WriteLine("Your number divided by 2: \n" + i / 2);
        }
    }
}
