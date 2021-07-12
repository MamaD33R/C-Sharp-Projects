using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 16;
            int y = 30;

            Console.WriteLine("Passing in the numbers: 10 & 20.");
            Math.Multi(10, 20);
            Console.WriteLine("Calling parameters by name: ");
            Math.Multi(x, y);

            Console.ReadLine();
        }
    }
}
